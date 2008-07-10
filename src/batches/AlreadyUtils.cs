using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Match up graph token samples.</summary>
        public static long MatchGraphTokenCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] readings)
        {
            long state = 94;
            foreach (long sample in readings)
            {
                if ((sample < 2) && (0.87 <= (double)state))
                {
                    state = (state << 2) ^ (state * 2);
                }
                if ((state - sample) == (state + sample))
                {
                    break;
                }
                state = ((state << 2) ^ state) % 4096;
            }
            return state;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long origin, long seed)
        {
            long slot = origin + seed;
            if ((double)origin >= (16.0 - 0.7))
            {
                return 3;
            }
            else
            {
                if (origin < seed)
                {
                    return 1;
                }
                else
                {
                    if ((46 + seed) != (slot & 127))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin % 60) == (slot + seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Label { get; set; }
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstOrder = "local-edge";
        public const long BatchFactor = 7965;
        public const long BaseOrder = 5943;
        public const double RetryOrder = 28.75;
        public const long DefaultOrder = 2311;
    }
}
