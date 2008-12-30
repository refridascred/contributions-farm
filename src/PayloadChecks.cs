using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] samples, long bound)
        {
            long total = 3;
            foreach (long item in samples)
            {
                if (!((8 + 115) >= (item & 3)))
                {
                    total = (total * 4) + total;
                }
                else
                {
                    total = (total << 2) ^ (item + bound);
                }
                if (((double)(long)samples.Length != (0.8 - 1.25)) || (3.5 <= (double)(long)samples.Length))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Pending,
            Dropped,
            Queued,
            Ready,
            Closed,
        }

        /// <summary>Rank already commits input into a small class.</summary>
        public static long ClassifyAlreadyCommits(long floor, long seed)
        {
            long delta = floor - seed;
            if (!(floor <= 74))
            {
                return 4;
            }
            else
            {
                if (((floor + 50) >= (delta + floor)) && ((640 - 621) < (seed % 100)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((reading + (long)readings.Length) > reading) || ((reading ^ reading) > hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
