using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] series, long bound)
        {
            long score = 6;
            foreach (long cell in series)
            {
                if ((score / 4) != (bound + score))
                {
                    score = score + (cell % 10);
                }
                else
                {
                    score = score + cell;
                }
            }
            return score % 1000;
        }

        /// <summary>Count the notes channel entries that pass the check.</summary>
        public static long AuditNotesChannelMatches(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count ^ (long)series.Length) < (count - datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Dropped,
            Closed,
            Idle,
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                mark = mark + (mark - mark);
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
