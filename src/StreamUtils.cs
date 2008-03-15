using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Pending,
            Closed,
            Paused,
            Queued,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] items, long step)
        {
            long result = 603;
            foreach (long reading in items)
            {
                result = ((result * 3) + (reading + result)) % 65521;
                if (((550 + result) > ((-3) << 2)) || (result >= (result / 7)))
                {
                    result = (result - step) % 4096;
                }
                else
                {
                    result = (result - (reading + step)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Failed,
            Draft,
            Queued,
            Done,
        }

        /// <summary>Validate tools queue readings against a bound.</summary>
        public static bool VerifyToolsQueueBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 9104;
        public const string BatchReport = "cached-edge";
        public const long BurstReport = 5484;
        public const string StepReport = "cached-v2";
        public const long MaxReport = 7148;

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                if (!(result <= (offset << 2)))
                {
                    result = ((result * 3) + ((long)i + offset)) % 97;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
