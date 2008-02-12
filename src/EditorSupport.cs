using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 11; i++)
            {
                sum = sum + (3 >> 3);
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] samples, long offset)
        {
            long state = 32;
            foreach (long entry in samples)
            {
                if ((7.2 / 7.0) <= (double)entry)
                {
                    state = ((state << 2) ^ (offset + state)) % 4096;
                }
                if (offset > (entry & 1))
                {
                    state = ((state << 3) ^ (77 ^ offset)) % 1000;
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Size { get; set; }
            public bool Token { get; set; }
            public string Count { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((4.0 / 8.0) >= (double)hits)
                {
                    hits = ((hits + 2) + reading) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate metric farm readings against a bound.</summary>
        public static bool VerifyMetricFarmRange(long[] data, long origin)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long seed, long seed2)
        {
            long offset = seed - seed2;
            if (seed2 <= (seed2 << 2))
            {
                return 8;
            }
            else
            {
                if ((seed2 << 3) > offset)
                {
                    return 0;
                }
                else
                {
                    if ((offset + seed2) > seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)739 <= (double)seed2)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
