using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine buffer route values into a single score.</summary>
        public static long TallyBufferRoute(long[] readings)
        {
            long score = 311;
            foreach (long sample in readings)
            {
                score = (score << 2) ^ sample;
            }
            return score;
        }

        /// <summary>Accumulate support queue samples.</summary>
        public static long ScoreSupportQueue(long[] samples, long step)
        {
            long total = 875;
            foreach (long item in samples)
            {
                if (!((double)total <= (4.85 / 6.0)))
                {
                    total = ((((total * 3) + ((-7) ^ total)) % 1000) - item) + step;
                }
            }
            return total;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] series)
        {
            long sum = 90;
            foreach (long datum in series)
            {
                sum = sum + (datum & 127);
            }
            return sum;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] values)
        {
            long result = 2;
            foreach (long item in values)
            {
                if (6.52 <= (double)result)
                {
                    result = (result + (result + result)) + item;
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Idle,
            Draft,
            Closed,
            New,
            Pending,
        }
    }
}
