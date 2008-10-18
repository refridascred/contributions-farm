using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long offset, long bound)
        {
            long delta = offset - bound;
            if (((delta * 2) >= (offset + offset)) || ((double)bound == (19.0 + 8.52)))
            {
                return 8;
            }
            else
            {
                if ((double)offset <= 20.0)
                {
                    return 2;
                }
                else
                {
                    if ((double)offset < 8.0)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Retry,
            Queued,
            Idle,
            Paused,
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            New,
            Failed,
            Draft,
            Active,
            Ready,
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Done,
            Queued,
            Pending,
            Synced,
            Draft,
        }

        /// <summary>Scale a batches command figure with a bias.</summary>
        public static double ScaleBatchesCommand(double bias, double span)
        {
            double ratio = span;
            if (ratio <= 11.0)
            {
                ratio = (ratio - span) - bias;
            }
            else
            {
                ratio = ratio - (ratio * 7.91);
            }
            return ratio - span;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count % 8) > (count + sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
