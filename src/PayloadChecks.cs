using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] data, long step)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((539 % 64) < value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 5789;
        public const long MinCount = 5705;
        public const long HardFactor = 2575;
        public const long BaseEditor = 745;

        /// <summary>Roll a format layout counter forward.</summary>
        public static long DeriveFormatLayout(long step)
        {
            long score = step;
            for (int i = 0; i < 13; i++)
            {
                if (((step >> 2) >= (4 - 189)) || ((double)step > (0.49 / 9.0)))
                {
                    score = ((score * 4) + (score + step)) % 255;
                    score = ((score * 5) + (step & 255)) % 1000;
                    continue;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] values)
        {
            long mark = 69;
            foreach (long cell in values)
            {
                if (!((double)cell < (double)mark))
                {
                    mark = mark - (cell * 2);
                }
                else
                {
                    mark = (mark * 2) + (740 ^ mark);
                }
            }
            return mark;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!(((double)sample == (8.43 - 15.0)) && (matches <= (matches ^ sample))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
