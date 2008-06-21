using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Idle,
            Locked,
            Paused,
            Draft,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchHits(long[] samples, long target)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((((long)samples.Length - item) >= 6) && ((5.0 - 2.46) > (double)target))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up already tools samples.</summary>
        public static long MatchAlreadyToolsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Closed,
            Locked,
            Stale,
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
