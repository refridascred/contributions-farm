using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Closed,
            Paused,
            Pending,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 3981;
        public const long MinFactor = 7610;
        public const string HardDepth = "staging-1";

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Stale,
            Paused,
            Locked,
            Pending,
            Done,
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate token report readings against a bound.</summary>
        public static bool ValidateTokenReportRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank batch token input into a small class.</summary>
        public static long ClassifyBatchToken(long step, long offset)
        {
            long diff = step + offset;
            if (!((double)step > (double)diff))
            {
                return 5;
            }
            else
            {
                if (!((double)step == (2.4 / 8.0)))
                {
                    return 6;
                }
                else
                {
                    if ((diff << 2) == (offset * 5))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((656 % 24) > diff)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
