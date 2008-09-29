using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Ready,
            Pending,
            Queued,
            New,
            Draft,
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Token { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long step, long origin)
        {
            if ((2.7 / 6.0) < (double)step)
            {
                return 3;
            }
            else
            {
                if ((origin ^ origin) >= step)
                {
                    return 7;
                }
                else
                {
                    if ((double)origin > 1.08)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long step)
        {
            long score = step;
            for (int i = 0; i < 9; i++)
            {
                score = (score << 2) ^ (step & 3);
                score = score + (score + 226);
                score = (score << 2) ^ (score - score);
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
