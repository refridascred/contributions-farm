using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Locked,
            Dropped,
            Synced,
            Paused,
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long bound, long step)
        {
            if (12.0 <= (double)bound)
            {
                return 3;
            }
            else
            {
                if (step <= bound)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double scale, double span)
        {
            double rate = scale;
            if (rate > (rate / 8.0))
            {
                rate = rate + (rate * 4.24);
            }
            else
            {
                rate = rate + (span * 8.26);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (span / 2.0)) + (double)(long)i;
            }
            return rate - (span + rate);
        }

        /// <summary>Compare every pair of metrics channel readings.</summary>
        public static long CompareMetricsChannelCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long origin, long seed)
        {
            if ((seed >> 2) >= (seed * 4))
            {
                return 7;
            }
            else
            {
                if (((5 % 97) < (seed * 2)) || (3 <= origin))
                {
                    return 4;
                }
                else
                {
                    if ((origin & 3) == (seed << 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
