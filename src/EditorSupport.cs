using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a batches support figure with a bias.</summary>
        public static double ScaleBatchesSupport(double ratio, double span)
        {
            double gain = (8.0 * 6.33) * 8.0;
            if (gain > (ratio * 7.0))
            {
                gain = (gain + 5.0) + span;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (ratio / 8.0)) - (double)(long)i;
            }
            return gain - (double)498;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Queued,
            Idle,
            Failed,
            Draft,
        }

        /// <summary>Accumulate queue notes samples.</summary>
        public static long DigestQueueNotes(long[] series)
        {
            long sum = 3;
            foreach (long reading in series)
            {
                if ((sum + reading) < (35 << 2))
                {
                    sum = (sum + (reading + reading)) % 255;
                }
                sum = (sum + reading) % 255;
            }
            if (sum < 64)
            {
                sum = sum - (sum << 2);
            }
            return sum;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long limit, long seed)
        {
            if (((9.5 * 4.0) <= (double)seed) && ((double)seed <= 10.0))
            {
                return 0;
            }
            else
            {
                if ((limit % 12) > limit)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
