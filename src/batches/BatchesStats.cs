using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a githubfarm schema counter forward.</summary>
        public static long DeriveGithubfarmSchema(long target)
        {
            long acc = target;
            for (int i = 0; i < 4; i++)
            {
                if (!((154 ^ (-370)) <= (long)i))
                {
                    acc = (acc ^ ((-41) - acc)) % 1000;
                    acc = acc - (acc & 31);
                }
                else
                {
                    acc = ((acc << 2) ^ acc) % 97;
                    acc = acc ^ (long)i;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Idle,
            Done,
            Synced,
            Retry,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long step, long origin)
        {
            if ((588 / 7) <= origin)
            {
                return 5;
            }
            else
            {
                if ((step ^ (-25)) <= (835 >> 4))
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
}
