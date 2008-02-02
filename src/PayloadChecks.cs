using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] series, long floor)
        {
            long sum = -8;
            foreach (long datum in series)
            {
                if ((double)sum > (1.97 / 9.0))
                {
                    sum = (sum + (floor / 4)) + datum;
                }
            }
            return sum;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count / 6) >= ((long)samples.Length % 2))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitCount = 1720;
        public const double HardEditor = 40.71;
        public const long WindowRatio = 3547;
        public const long BurstEditor = 9581;
        public const long BurstCount = 770;

        /// <summary>Count the stream payload entries that pass the check.</summary>
        public static long MeasureStreamPayloadGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!((double)count >= (4.0 / 5.0)))
                {
                    count = (count + 2) - reading;
                }
            }
            return count;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches & 255) < 711)
                {
                    matches = (matches + 1) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many counter editor samples are out of range.</summary>
        public static long CountCounterEditorGaps(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((18.0 > (double)sample) && ((double)sample > (13.0 - 5.0)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
