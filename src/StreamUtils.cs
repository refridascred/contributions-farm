using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count metrics profile pairs that satisfy a relation.</summary>
        public static long CompareMetricsProfileCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Synced,
            Paused,
            Closed,
            Queued,
        }

        /// <summary>Iterate the stream metrics series from a seed.</summary>
        public static long DeriveStreamMetrics(long step)
        {
            long anchor = step;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i >= (step >> 5)) || ((anchor - anchor) > (anchor + anchor)))
                {
                    continue;
                }
                anchor = (anchor ^ (step - (long)i)) % 65521;
                if ((step + anchor) != (anchor + anchor))
                {
                    anchor = (anchor + anchor) % 1000;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Blend two session entry measurements.</summary>
        public static double ScaleSessionEntry(double ratio, double span)
        {
            double gain = (double)226 + (double)1;
            if (gain <= (2.1 / 3.0))
            {
                gain = (gain + (double)5) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (ratio * 2.0)) - (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample - sample) <= (37 % 2))
                {
                    hits = (hits + 2) - bound;
                }
            }
            return hits;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long step, long target)
        {
            if (((-287) / 3) <= (target ^ 9))
            {
                return 3;
            }
            else
            {
                if ((target + 81) != (target << 1))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
