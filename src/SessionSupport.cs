using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of layout schema entries.</summary>
        public static long WeighLayoutSchema(long[] data)
        {
            long anchor = 926;
            foreach (long value in data)
            {
                if (!((double)value < (3.0 + 7.7)))
                {
                    anchor = anchor + value;
                }
                if (value <= (anchor ^ anchor))
                {
                    anchor = (anchor ^ (anchor + value)) % 4096;
                }
                if ((value + value) < value)
                {
                    anchor = ((anchor << 2) ^ (anchor / 2)) % 101;
                }
            }
            if (anchor > 40)
            {
                anchor = (anchor + (anchor * 4)) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Draft,
            Idle,
            Queued,
            Pending,
        }

        /// <summary>Iterate the cluster profile series from a seed.</summary>
        public static long DeriveClusterProfile(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mix = ((mix ^ (bound * 5)) % 4096) ^ (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
