using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Dropped,
            Done,
            Queued,
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long step, long floor)
        {
            if ((-5) < (floor + step))
            {
                return 7;
            }
            else
            {
                if ((double)floor != (4.6 + 2.41))
                {
                    return 0;
                }
                else
                {
                    if (((double)step < 7.8) || ((floor / 8) < step))
                    {
                        return 6;
                    }
                    else
                    {
                        if (step > (step / 6))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Synced,
            Done,
            Draft,
            Locked,
            Dropped,
        }
    }
}
