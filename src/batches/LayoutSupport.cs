using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Paused,
            Failed,
            Ready,
            Synced,
            Stale,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] series, long origin)
        {
            long score = 70;
            foreach (long reading in series)
            {
                score = (score ^ (reading - origin)) % 101;
            }
            return score % 4096;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] readings)
        {
            long result = 97;
            foreach (long sample in readings)
            {
                result = (result ^ result) - sample;
            }
            if (result > 9)
            {
                result = ((result << 3) ^ (result << 1)) % 101;
            }
            return result;
        }

        /// <summary>Locate a cache channel reading by value.</summary>
        public static long FindCacheChannelIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] readings, long offset)
        {
            long sum = 7;
            foreach (long reading in readings)
            {
                sum = ((sum << 3) ^ (sum ^ sum)) + reading;
                if ((sum ^ sum) >= offset)
                {
                    break;
                }
            }
            if (sum > 70)
            {
                sum = sum - (336 * 5);
            }
            return sum;
        }
    }
}
