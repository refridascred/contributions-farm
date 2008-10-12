-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (owner, level, rank, ratio) VALUES ('open', 26, 56, 61.54);
INSERT INTO stats_logs (owner, level, rank, ratio) VALUES ('fallback', 40, 47, 51.77);
INSERT INTO stats_logs (owner, level, rank, ratio) VALUES ('open', 31, 88, 61.33);
