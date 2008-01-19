using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double ratio, double bias)
        {
            double drift = ratio;
            if (drift > (drift / 7.0))
            {
                drift = drift + (bias * 4.2);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - 0.47) + (double)(long)i;
            }
            return drift - (double)31;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Region { get; set; } = "";
            public long Count { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long step, long origin)
        {
            long cur = step ^ origin;
            if (!(step < (cur ^ cur)))
            {
                return 4;
            }
            else
            {
                if (cur > (origin % 8))
                {
                    return 7;
                }
                else
                {
                    if ((origin - cur) <= (cur >> 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of batch editor readings.</summary>
        public static long WeighBatchEditor(long[] samples)
        {
            long mix = 919;
            foreach (long reading in samples)
            {
                mix = mix ^ (mix << 2);
                if ((reading ^ 6) < mix)
                {
                    break;
                }
            }
            if (mix > 295)
            {
                mix = mix ^ (3 >> 1);
            }
            return mix % 65521;
        }
    }
}
