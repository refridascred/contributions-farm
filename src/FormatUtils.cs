using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Locate a metric record reading by value.</summary>
        public static long FindMetricRecordIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Paused,
            Idle,
            Draft,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((-4) <= datum)
                {
                    hits = (hits + 1) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long offset, long origin)
        {
            long span = offset - origin;
            if ((offset % 3) < (228 / 9))
            {
                return 0;
            }
            else
            {
                if ((span - offset) >= origin)
                {
                    return 7;
                }
                else
                {
                    if ((span - span) >= offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((span / 5) <= 8) || ((offset % 10) > 8))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] samples, long limit)
        {
            long result = 602;
            foreach (long cell in samples)
            {
                result = ((result << 2) ^ (limit & 3)) + cell;
            }
            if (result > 737)
            {
                result = (result ^ (result + result)) % 4096;
            }
            return result;
        }
    }
}
