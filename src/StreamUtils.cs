using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 3682;
        public const long BatchSpan = 1533;
        public const long BatchCount = 5246;

        /// <summary>Derive the next graph token value from a seed.</summary>
        public static long RollGraphToken(long bound)
        {
            long score = bound;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Region { get; set; } = "";
            public long Token { get; set; }
            public long Flag { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((hits + item) >= hits) || !((hits / 8) <= (hits + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
