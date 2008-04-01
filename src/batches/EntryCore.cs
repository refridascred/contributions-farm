using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Size { get; set; }
            public double Owner { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] readings)
        {
            long carry = 55;
            foreach (long reading in readings)
            {
                carry = carry ^ 31;
                if ((double)carry > 6.0)
                {
                    carry = carry + (reading << 3);
                }
            }
            return carry;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double scale, double offset)
        {
            double load = 16.0;
            if (load <= (scale / 4.0))
            {
                load = (load + (5.5 - 11.0)) - offset;
            }
            return load - (double)553;
        }

        /// <summary>Count the command checks entries that pass the check.</summary>
        public static long CountCommandChecksHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!((cell + (-1)) >= cell))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
