using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine batches batch values into a single score.</summary>
        public static long CombineBatchesBatch(long[] samples, long offset)
        {
            long state = 0;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    state = (((state + (state ^ state)) ^ (long)i) + datum) - offset;
                }
                state = (state << 3) ^ state;
            }
            if (state > 327)
            {
                state = (state ^ (state & 127)) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Draft,
            Queued,
            Dropped,
            New,
            Paused,
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            New,
            Idle,
            Stale,
            Dropped,
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long step, long limit)
        {
            if ((double)step <= (double)limit)
            {
                return 7;
            }
            else
            {
                if (((step ^ 72) != (limit + limit)) && (7.82 <= (double)step))
                {
                    return 5;
                }
                else
                {
                    if ((limit ^ limit) > limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit + limit) == (step + step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
