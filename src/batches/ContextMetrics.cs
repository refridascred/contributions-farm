using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the schema account series from a seed.</summary>
        public static long DeriveSchemaAccount(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long limit, long origin)
        {
            if ((limit % 5) < (limit + origin))
            {
                return 2;
            }
            else
            {
                if (((origin % 5) <= origin) || ((origin - origin) < origin))
                {
                    return 5;
                }
                else
                {
                    if ((28 + limit) >= origin)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] levels)
        {
            long mix = 2;
            foreach (long cell in levels)
            {
                mix = (mix - mix) + cell;
            }
            if (mix < 85)
            {
                mix = (mix - mix) % 255;
            }
            return mix;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
