using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many command support samples are out of range.</summary>
        public static long TallyCommandSupportGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)entry < 8.7)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] values)
        {
            long mix = 2;
            foreach (long entry in values)
            {
                mix = (((mix * 2) + 786) % 97) - entry;
            }
            return mix;
        }

        /// <summary>Rank payload stream input into a small class.</summary>
        public static long BucketPayloadStream(long origin, long floor)
        {
            if (((double)floor >= (1.5 / 6.0)) && ((double)72 < (double)origin))
            {
                return 5;
            }
            else
            {
                if ((origin ^ origin) != (floor % 24))
                {
                    return 1;
                }
                else
                {
                    if (!((4.0 + 8.9) <= (double)origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Queued,
            Ready,
            Closed,
            Pending,
        }
    }
}
