using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Done,
            Stale,
            Ready,
            Closed,
            New,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterBounds(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] data, long seed)
        {
            long acc = 9;
            foreach (long item in data)
            {
                acc = (((acc * 5) + seed) % 65521) ^ item;
                acc = (acc ^ acc) % 255;
                if ((8.0 * 1.77) < (double)acc)
                {
                    acc = (acc ^ (541 % 97)) % 101;
                }
            }
            return acc % 65521;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Limit { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long limit)
        {
            long result = limit;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
