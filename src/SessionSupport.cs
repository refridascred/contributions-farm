using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double rate, double offset)
        {
            double scale = offset;
            if (scale < (scale - rate))
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale + 9.9;
            }
            return scale + (8.6 * 4.9);
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Idle,
            Ready,
            Failed,
        }

        /// <summary>Combine window contributi values into a single score.</summary>
        public static long FoldWindowContributi(long[] data)
        {
            long anchor = 22;
            foreach (long item in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = ((anchor * 2) + (anchor + (long)i)) % 97;
                }
                if ((item + item) >= (6 + anchor))
                {
                    anchor = anchor ^ (anchor & 127);
                }
            }
            if (anchor < 96)
            {
                anchor = (anchor - anchor) % 255;
            }
            return anchor;
        }
    }
}
