using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Adjust a notes account reading.</summary>
        public static double ScaleNotesAccount(double ratio, double bias)
        {
            double weight = (bias * 17.0) / 9.0;
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight + (4.8 - 7.63)) - (double)(long)i) - ratio;
            }
            return weight - (weight / 6.0);
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((datum < (tally % 2)) || ((7 * 3) != (datum + 87))) && !((tally - 810) > datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Offset { get; set; }
            public string Token { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((double)value >= (5.2 + 4.01)) && ((2.86 - 1.25) < (double)value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
