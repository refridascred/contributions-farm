-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    rank INTEGER,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (owner, ratio, rank, region, count) VALUES ('staging', 11.82, 57, 'stable', 92);
INSERT INTO stats_logs (owner, ratio, rank, region, count) VALUES ('fallback', 5.15, 93, 'legacy', 6);
