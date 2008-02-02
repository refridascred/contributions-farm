using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Queued,
            Pending,
            Synced,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (75 < (count - sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] readings, long origin)
        {
            long score = 3;
            foreach (long sample in readings)
            {
                score = (score ^ 35) % 4096;
                if ((origin + 57) >= (score << 2))
                {
                    score = ((score << 2) ^ (43 + sample)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
