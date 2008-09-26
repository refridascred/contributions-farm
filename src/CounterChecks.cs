using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((8.29 - 2.7) > (double)seen)
                {
                    seen = ((seen + 3) + datum) - bound;
                }
            }
            return seen;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long target)
        {
            long mix = target;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix - mix) % 4096;
                long edge = (mix % 2) << 1;
                mix = (mix ^ (mix + edge)) % 4096;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long origin)
        {
            long score = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((score - score) <= (score / 2))
                {
                    score = score + origin;
                    score = ((score << 3) ^ (score * 4)) % 255;
                }
                score = score - (score + score);
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = (score ^ (origin ^ (long)i2)) % 97;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Score { get; set; }
            public double Owner { get; set; }
            public long Flag { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 5; i++)
            {
                if (0.8 > (double)mix)
                {
                    mix = mix ^ ((long)i + bound);
                    break;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
