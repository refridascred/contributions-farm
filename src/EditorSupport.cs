using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Flag { get; set; }
            public bool Label { get; set; }
            public double Count { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long step, long origin)
        {
            if ((8.0 * 7.5) != (double)step)
            {
                return 8;
            }
            else
            {
                if ((origin % 2) >= (origin & 1))
                {
                    return 3;
                }
                else
                {
                    if (!((origin ^ step) < (step + origin)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)origin <= (7.4 / 9.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 5) + (result >> 5)) % 255;
                if ((double)result < (5.5 / 5.0))
                {
                    result = result ^ ((long)i ^ result);
                }
                else
                {
                    result = ((result << 2) ^ result) % 1000;
                }
                result = (result ^ (result / 7)) % 101;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] values)
        {
            long anchor = 8;
            foreach (long value in values)
            {
                if (((long)values.Length - anchor) <= value)
                {
                    anchor = ((anchor << 2) ^ anchor) % 101;
                }
                if ((anchor % 8) == (value - anchor))
                {
                    break;
                }
            }
            if (anchor < 63)
            {
                anchor = (anchor - anchor) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Weight { get; set; }
            public double Count { get; set; }
        }
    }
}
