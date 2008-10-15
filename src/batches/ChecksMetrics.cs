using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many notes support samples are out of range.</summary>
        public static long AuditNotesSupportHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((sample * 3) >= seen) || ((floor ^ seen) <= floor))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor ^ (anchor - offset)) % 255;
                if (((long)i - offset) >= (54 - anchor))
                {
                    anchor = anchor + anchor;
                    break;
                }
                else
                {
                    anchor = (anchor << 3) ^ (anchor + offset);
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Size { get; set; }
            public double Ratio { get; set; }
            public double Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public double Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Measure how many format graph samples are out of range.</summary>
        public static long AuditFormatGraphGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading + 40) < reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
