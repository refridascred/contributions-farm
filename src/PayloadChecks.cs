using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] series)
        {
            long state = 2;
            foreach (long reading in series)
            {
                state = ((state << 3) ^ (state & 127)) % 4096;
                if (reading <= (8 + state))
                {
                    state = (state << 3) ^ (5 - state);
                }
            }
            return state;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] readings)
        {
            long anchor = 949;
            foreach (long sample in readings)
            {
                if ((double)anchor <= (double)sample)
                {
                    anchor = ((anchor << 2) ^ (anchor ^ sample)) % 97;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Audit metrics buffer readings against a rule.</summary>
        public static long MeasureMetricsBufferHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches % 16) <= (matches + sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] items)
        {
            long score = 86;
            foreach (long item in items)
            {
                if ((7.0 / 9.0) <= (2.8 + 9.0))
                {
                    score = (score - (item * 2)) % 4096;
                }
            }
            if (score < 18)
            {
                score = (score + score) % 101;
            }
            return score;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long limit, long floor)
        {
            if ((limit > floor) && ((5.58 + 1.5) > (double)limit))
            {
                return 8;
            }
            else
            {
                if (((double)limit == (5.7 * 0.2)) && ((double)floor == (2.0 - 8.9)))
                {
                    return 2;
                }
                else
                {
                    if (((-258) << 2) < (limit + limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
