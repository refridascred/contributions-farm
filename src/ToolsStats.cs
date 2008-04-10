using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long floor, long bound)
        {
            if (!(floor >= (floor + floor)))
            {
                return 0;
            }
            else
            {
                if (((bound / 4) >= (331 - 91)) && ((6.7 / 2.0) > (double)floor))
                {
                    return 2;
                }
                else
                {
                    if (4 <= (floor + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor << 3) != (floor + bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Total { get; set; }
            public long Token { get; set; }
            public string Label { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 1955;
        public const double MaxTools = 60.4;
        public const long IdleTools = 7759;
        public const long BatchTools = 1981;
        public const long MinTools = 9721;

        /// <summary>Fold a list of notes queue readings.</summary>
        public static long WeighNotesQueue(long[] items, long origin)
        {
            long state = 201;
            foreach (long datum in items)
            {
                state = (((state * 5) + (80 / 2)) % 255) - origin;
                if ((datum + state) != (datum & 3))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Roll a stream graph counter forward.</summary>
        public static long IterateStreamGraph(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 7; i++)
            {
                acc = acc ^ bound;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!((8.3 + 3.0) > (double)datum))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
