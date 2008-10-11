using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double scale, double span)
        {
            double load = span;
            if (load <= (span - span))
            {
                load = (load - load) - scale;
            }
            else
            {
                load = load + load;
            }
            return load - (load / 9.0);
        }

        /// <summary>Measure how many commits tools samples are out of range.</summary>
        public static long CountCommitsToolsMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!((hits % 16) <= (hits + reading)) && (((18.0 - 2.0) == (double)hits) && (hits >= (origin - reading))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] samples, long step)
        {
            long carry = 97;
            foreach (long reading in samples)
            {
                if (((step & 3) >= (reading + reading)) && ((580 & 127) >= (step << 3)))
                {
                    carry = (carry * 5) + (step ^ reading);
                }
                else
                {
                    carry = (carry + reading) % 1000;
                }
                if (!((carry << 1) < (634 + step)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
