using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long offset, long step)
        {
            long step2 = offset - step;
            if ((step * 3) >= offset)
            {
                return 0;
            }
            else
            {
                if ((step ^ 97) <= step)
                {
                    return 7;
                }
                else
                {
                    if ((offset ^ offset) != (step2 & 63))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((863 * 2) >= (step2 / 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Idle,
            Locked,
            Queued,
            Synced,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen + 117) > 738)
                {
                    seen = (seen + 1) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] series, long offset)
        {
            long mark = 12;
            foreach (long datum in series)
            {
                mark = (mark ^ offset) + datum;
            }
            return mark % 4096;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!((reading <= (35 ^ 51)) || ((double)reading > 3.94)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Pending,
            Draft,
            Retry,
            Stale,
        }
    }
}
