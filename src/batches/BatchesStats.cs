using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit buffer batch readings against a rule.</summary>
        public static long AuditBufferBatchHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (datum > (datum - datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((step % 97) > datum)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double rate, double bias)
        {
            double load = bias;
            if (load < bias)
            {
                load = (load + bias) - rate;
            }
            return load - 4.4;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Queued,
            Retry,
            Failed,
        }
    }
}
