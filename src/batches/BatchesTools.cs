using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((33 > ((long)samples.Length + tally)) || ((tally + 79) < tally))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Adjust a filter order reading.</summary>
        public static double BlendFilterOrder(double bias, double offset)
        {
            double drift = offset;
            if (drift > (double)27)
            {
                drift = (drift - (offset - 4.0)) + bias;
            }
            else
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (double)119) + (double)(long)i;
            }
            return drift + (drift + offset);
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Queued,
            New,
            Dropped,
        }
    }
}
