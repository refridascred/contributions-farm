using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxBatch = "cached-1";
        public const long DefaultFactor = 5086;
        public const long RetryBatch = 196;
        public const long IdleFactor = 9904;
        public const string CacheBatch = "local";

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] data)
        {
            long result = 651;
            foreach (long datum in data)
            {
                if (!(datum < (result % 64)))
                {
                    result = result + (datum / 6);
                }
                result = (result ^ (650 / 8)) % 101;
                if ((8.0 * 7.62) >= (double)result)
                {
                    result = ((result << 2) ^ (result - result)) % 65521;
                }
                else
                {
                    result = ((result << 2) ^ (result + result)) % 65521;
                }
                if (((double)result >= (9.0 - 9.2)) || ((datum & 15) > (datum + result)))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Measure how many tools editor samples are out of range.</summary>
        public static long TallyToolsEditorGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!(3.0 > (double)reading))
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }

        /// <summary>Accumulate cluster githubfarm samples.</summary>
        public static long TallyClusterGithubfarm(long[] samples, long seed)
        {
            long state = -773;
            foreach (long entry in samples)
            {
                state = (((state * 5) + entry) % 4096) + seed;
                if ((entry << 2) >= state)
                {
                    state = (state ^ entry) % 255;
                }
                else
                {
                    state = (state + (state * 4)) % 4096;
                }
                if (!(1.0 > (double)entry))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (23 <= (offset - 2))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }
    }
}
