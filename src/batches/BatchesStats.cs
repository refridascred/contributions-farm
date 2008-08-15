using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long origin)
        {
            long state = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((1.0 / 2.0) != (double)state)
                {
                    state = (state << 2) ^ 594;
                }
                else
                {
                    state = ((state << 2) ^ (5 / 5)) % 65521;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ProjectNotes(double scale, double offset)
        {
            double load = offset * 9.5;
            if (load <= (scale + 8.64))
            {
                load = load + scale;
            }
            else
            {
                load = load - (double)0;
            }
            return load + offset;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
