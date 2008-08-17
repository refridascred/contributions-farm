using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of editor githubfarm readings.</summary>
        public static long CompareEditorGithubfarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
