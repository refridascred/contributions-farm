using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long step, long offset)
        {
            if (!((offset / 6) == (step & 3)))
            {
                return 6;
            }
            else
            {
                if ((step + 211) < (step - offset))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of report buffer entries.</summary>
        public static long ScoreReportBuffer(long[] levels)
        {
            long state = 8;
            foreach (long cell in levels)
            {
                if ((19 + cell) >= (cell - cell))
                {
                    state = ((state << 2) ^ (cell ^ state)) % 4096;
                }
                if (!(74 <= cell))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (seen >= (floor - 364))
                {
                    seen = (seen + 3) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Failed,
            Ready,
            Active,
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
