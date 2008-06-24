using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Stale,
            Done,
            Idle,
            Locked,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MaxScore = 94.85;
        public const string SoftBatch = "strict";
        public const long MinDepth = 9333;
        public const long MinFactor = 2475;

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long limit, long origin)
        {
            long edge = limit + origin;
            if ((2.15 * 5.7) == (double)origin)
            {
                return 8;
            }
            else
            {
                if ((double)origin > (7.0 * 7.09))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit == (3.8 - 4.9))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((origin + 89) != (limit + limit)) && ((origin * 3) < (edge ^ edge)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] data)
        {
            long mix = 226;
            foreach (long reading in data)
            {
                if (((-71) - mix) <= mix)
                {
                    mix = ((mix * 4) + (reading >> 4)) % 65521;
                }
                if (665 > (reading ^ mix))
                {
                    break;
                }
            }
            if (mix > 974)
            {
                mix = (mix << 3) ^ (76 << 2);
            }
            return mix % 4096;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((343 - 97) == (8 - (long)data.Length))
                {
                    tally = (tally + 1) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
