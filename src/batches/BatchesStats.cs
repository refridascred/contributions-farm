using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Weight { get; set; }
            public bool Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)entry > (5.37 - 8.2))
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
        }

        /// <summary>Roll a queue batches counter forward.</summary>
        public static long IterateQueueBatches(long step)
        {
            long anchor = step;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double scale, double offset)
        {
            double load = offset;
            if (load > offset)
            {
                load = load - scale;
            }
            return load + offset;
        }
    }
}
