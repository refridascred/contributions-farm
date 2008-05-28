using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate queue channel readings against a bound.</summary>
        public static bool VerifyQueueChannelBounds(long[] series, long target)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (6.54 < (double)cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long origin, long offset)
        {
            long bound = origin + offset;
            if ((offset < (469 / 3)) || ((bound + origin) == (bound % 64)))
            {
                return 2;
            }
            else
            {
                if ((bound > ((-3) << 2)) && ((double)offset <= (double)38))
                {
                    return 8;
                }
                else
                {
                    if (((origin / 8) == (7 & 127)) || (bound < (offset - 465)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (offset > 5)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] values, long offset)
        {
            long total = 63;
            foreach (long reading in values)
            {
                if ((total % 24) >= (total + offset))
                {
                    total = (total ^ (reading % 7)) % 4096;
                }
                if (reading > offset)
                {
                    break;
                }
            }
            return total % 65521;
        }
    }
}
