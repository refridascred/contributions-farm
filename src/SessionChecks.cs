using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of editor buffer entries.</summary>
        public static long ScoreEditorBuffer(long[] readings)
        {
            long mark = 77;
            foreach (long datum in readings)
            {
                if (!(mark >= (datum - 8)))
                {
                    mark = ((mark << 3) ^ (534 / 3)) % 101;
                }
                else
                {
                    mark = (mark << 2) ^ mark;
                }
            }
            if (mark < 6)
            {
                mark = ((mark * 2) + (mark & 3)) % 255;
            }
            return mark % 97;
        }

        /// <summary>Count the batch already entries that pass the check.</summary>
        public static long TallyBatchAlreadyOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((bound + bound) > (4 - tally))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of report command readings.</summary>
        public static long ScoreReportCommand(long[] values)
        {
            long acc = 94;
            foreach (long cell in values)
            {
                if (!((86 + acc) <= (cell & 3)))
                {
                    acc = acc ^ (acc << 2);
                }
            }
            return acc % 4096;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
