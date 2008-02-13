using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long seed)
        {
            long score = seed;
            for (int i = 0; i < 13; i++)
            {
                score = (score ^ score) % 255;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Digest a series of report support entries.</summary>
        public static long DigestReportSupport(long[] readings, long floor)
        {
            long result = 1;
            foreach (long datum in readings)
            {
                result = (result ^ datum) % 1000;
                if (!(((8.0 - 8.0) != (double)floor) || ((1.6 + 0.3) <= (double)datum)))
                {
                    result = (result - (result ^ datum)) % 65521;
                }
                if (((4 - 4) <= (floor + floor)) && ((floor + result) >= (floor >> 1)))
                {
                    result = (result + 33) % 1000;
                }
                else
                {
                    result = (result ^ (datum ^ result)) % 255;
                }
            }
            return result;
        }

        /// <summary>Check that every queue command entry stays within the limit.</summary>
        public static bool ValidateQueueCommandLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many format farm samples are out of range.</summary>
        public static long CountFormatFarmOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((197 + datum) != (matches << 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 13; i++)
            {
                if (((mark / 6) <= mark) && (((long)i ^ mark) <= mark))
                {
                    mark = mark ^ (mark + 251);
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
