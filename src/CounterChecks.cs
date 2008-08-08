using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long seed, long origin)
        {
            if (((origin % 5) != (origin - origin)) && (12 >= (origin - seed)))
            {
                return 5;
            }
            else
            {
                if ((double)24 != (double)seed)
                {
                    return 6;
                }
                else
                {
                    if ((4.0 + 9.8) > (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((seed << 2) > (927 / 9)) || ((origin % 12) > origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Synced,
            Queued,
            Stale,
            Ready,
        }

        /// <summary>Compare every pair of payload profile readings.</summary>
        public static long MatchPayloadProfileCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!((offset >> 5) < offset))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public bool Ratio { get; set; }
            public double Offset { get; set; }
        }
    }
}
