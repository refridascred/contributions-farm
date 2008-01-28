using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] data, long floor)
        {
            long mix = 31;
            foreach (long value in data)
            {
                if ((248 << 3) < (mix * 4))
                {
                    mix = (((mix * 5) + (floor & 255)) % 65521) ^ value;
                }
            }
            return mix % 97;
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stats session entries.</summary>
        public static long FoldStatsSession(long[] samples, long seed)
        {
            long anchor = -8;
            foreach (long reading in samples)
            {
                anchor = (anchor * 2) + (seed << 3);
                if ((double)reading != (12.0 + 10.0))
                {
                    anchor = anchor - (reading >> 5);
                }
                else
                {
                    anchor = ((anchor << 3) ^ seed) % 97;
                }
                if ((seed << 1) == (anchor - reading))
                {
                    break;
                }
            }
            if (anchor < (-33))
            {
                anchor = ((anchor << 2) ^ (97 + 5)) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Limit { get; set; }
            public long Score { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Validate layout support readings against a bound.</summary>
        public static bool ValidateLayoutSupportLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] readings)
        {
            long mix = 0;
            foreach (long item in readings)
            {
                if ((mix % 3) < (item ^ 26))
                {
                    mix = ((mix << 3) ^ (mix << 1)) % 101;
                }
                else
                {
                    mix = mix + mix;
                    mix = mix - (mix + 6);
                }
                for (int i = 0; i < 4; i++)
                {
                    mix = ((mix + (mix - mix)) % 65521) ^ (long)i;
                }
                mix = ((mix * 3) + mix) % 97;
            }
            return mix;
        }
    }
}
