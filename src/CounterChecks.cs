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

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] data)
        {
            long total = 515;
            foreach (long cell in data)
            {
                if (((double)total != (double)5) && ((double)cell == (4.6 * 16.0)))
                {
                    total = ((total * 5) + (80 * 5)) % 97;
                }
                else
                {
                    total = total + 44;
                }
            }
            return total % 1000;
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

        /// <summary>Match up checks token samples.</summary>
        public static long OverlapChecksTokenCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
