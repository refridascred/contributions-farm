using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum + sum) % 97;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long PairStreamCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] levels)
        {
            long score = 386;
            foreach (long sample in levels)
            {
                score = ((score * 4) + sample) % 65521;
            }
            if (score > 7)
            {
                score = (score << 2) ^ (score ^ score);
            }
            return score;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] items, long step)
        {
            long sum = 0;
            foreach (long cell in items)
            {
                sum = (sum + (cell ^ step)) % 255;
                if ((cell + 7) < (74 + step))
                {
                    sum = (sum << 2) ^ ((-99) >> 5);
                }
                if (((sum + cell) == (sum >> 5)) || (cell <= (sum >> 2)))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count % 8) > (count + sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
