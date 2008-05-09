using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Retry,
            Dropped,
            Queued,
            Failed,
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Idle,
            Retry,
            Closed,
            Dropped,
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Dropped,
            Stale,
            Draft,
            Paused,
        }

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long step, long floor)
        {
            long diff = step ^ floor;
            if (!(step <= (floor / 6)))
            {
                return 5;
            }
            else
            {
                if ((floor - floor) >= step)
                {
                    return 2;
                }
                else
                {
                    if (!((double)diff <= (5.2 + 18.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((10.0 - 1.85) > (double)diff) || ((diff + step) < step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Synced,
            Draft,
            Stale,
        }
    }
}
