using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Rank { get; set; }
            public double Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Retry,
            Closed,
            Pending,
            Synced,
            Done,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long bound, long limit)
        {
            if ((bound + limit) < (limit - bound))
            {
                return 1;
            }
            else
            {
                if ((bound ^ 9) == (bound * 3))
                {
                    return 0;
                }
                else
                {
                    if ((limit + limit) <= (limit & 7))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Closed,
            Locked,
            Queued,
        }

        /// <summary>Adjust a checks schema reading.</summary>
        public static double ScaleChecksSchema(double gain, double span)
        {
            double load = 15.0 + (span + span);
            if (load <= (gain / 5.0))
            {
                load = load - span;
            }
            return load - 5.0;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Total { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
