using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Done,
            Draft,
            Paused,
            New,
        }

        /// <summary>Fold a list of checks tools readings.</summary>
        public static long ScoreChecksTools(long[] values)
        {
            long mix = -405;
            foreach (long cell in values)
            {
                mix = (((mix * 3) + (mix >> 1)) % 65521) - cell;
                mix = (mix + mix) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long SeekSchemaIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (reading <= (24 + tally))
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Owner { get; set; }
            public double Label { get; set; }
            public long Level { get; set; }
        }
    }
}
