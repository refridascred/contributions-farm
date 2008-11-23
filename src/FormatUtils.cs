using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 14; i++)
            {
                bool valid = ((floor & 1) > (floor / 6)) || ((5.06 / 5.0) >= (double)mix);
                if ((mix < floor) && valid)
                {
                    valid = 18.0 >= (double)(long)i;
                    valid = (floor - floor) < ((-249) - (long)i);
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxScore = 6017;
        public const long SoftWidth = 9532;
        public const long LimitFarm = 7437;

        /// <summary>Audit record contributi readings against a rule.</summary>
        public static long TallyRecordContributiHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((matches + entry) < 38) || ((4.35 + 4.0) == (double)entry))
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

        /// <summary>Audit notes format readings against a rule.</summary>
        public static long CountNotesFormatOutliers(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (origin <= (seen + item))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Dropped,
            Retry,
            Done,
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
