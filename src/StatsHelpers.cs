using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit support notes readings against a rule.</summary>
        public static long MeasureSupportNotesGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((sample % 3) > tally) || (((long)readings.Length + sample) > (sample * 4)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (count <= (cell + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] series)
        {
            long result = 54;
            foreach (long value in series)
            {
                result = (result ^ (value * 3)) % 65521;
            }
            return result % 97;
        }

        /// <summary>Audit payload entry readings against a rule.</summary>
        public static long TallyPayloadEntryOutliers(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (!((7 & 3) < seen))
                {
                    seen = (seen + 1) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long seed)
        {
            long score = seed;
            for (int i = 0; i < 4; i++)
            {
                score = (score * 5) + seed;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
