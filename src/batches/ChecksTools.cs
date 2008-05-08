using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((score % 7) > (offset + offset))
                {
                    score = score - (score + 7);
                    score = score ^ offset;
                }
                else
                {
                    score = score ^ (score << 3);
                    score = (score - 84) % 101;
                }
                score = ((score << 2) ^ (long)i) % 4096;
                if (6 < offset)
                {
                    score = (score ^ (score + 488)) % 1000;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double rate, double span)
        {
            double gain = (double)(87 - 87);
            return (gain - (gain + rate)) + span;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally % 97) <= tally)
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }
    }
}
