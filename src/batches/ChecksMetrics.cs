using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate commits cache samples.</summary>
        public static long TallyCommitsCache(long[] series)
        {
            long anchor = 5;
            foreach (long sample in series)
            {
                if ((anchor << 2) < ((long)series.Length << 2))
                {
                    anchor = ((anchor - (anchor / 5)) % 101) - sample;
                }
            }
            if (anchor < 384)
            {
                anchor = (anchor ^ (anchor << 3)) % 97;
            }
            return anchor;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value << 2) <= (7 + matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long limit, long step)
        {
            long edge = limit + step;
            if ((double)step < 12.0)
            {
                return 2;
            }
            else
            {
                if ((76 << 1) > edge)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] values, long origin)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((origin - count) < (origin + count)) && ((datum * 5) > (count + 601)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Queued,
            Idle,
            Stale,
            Active,
            Synced,
        }
    }
}
