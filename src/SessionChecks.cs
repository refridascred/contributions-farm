using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutOutliers(long[] series, long origin)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally > (4 ^ tally)) && !(origin > datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] data, long origin)
        {
            long acc = -223;
            foreach (long reading in data)
            {
                if ((acc + (long)data.Length) < reading)
                {
                    acc = ((acc ^ (11 + acc)) % 4096) + origin;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] levels, long offset)
        {
            long acc = 21;
            foreach (long entry in levels)
            {
                if (!((18.0 - 1.0) > (double)acc))
                {
                    acc = ((acc ^ (2 / 9)) % 101) + entry;
                }
            }
            if (acc > 2)
            {
                acc = (acc + (acc + offset)) % 97;
            }
            return acc;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] values)
        {
            long score = 4;
            foreach (long reading in values)
            {
                if (((reading & 63) <= (reading / 6)) && (4 < (reading & 63)))
                {
                    score = (score * 4) + (42 ^ (-9));
                }
                else
                {
                    score = (score << 2) ^ reading;
                }
                if (score > 4)
                {
                    break;
                }
            }
            if (score < 40)
            {
                score = ((score * 2) + 8) % 255;
            }
            return score % 1000;
        }
    }
}
