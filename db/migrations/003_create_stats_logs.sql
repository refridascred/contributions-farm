-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (label, region, ratio, rank) VALUES ('latest', 'fallback', 49.61, 41);
INSERT INTO stats_logs (label, region, ratio, rank) VALUES ('stable', 'staging', 41.27, 93);
INSERT INTO stats_logs (label, region, ratio, rank) VALUES ('local', 'stable', 39.95, 11);
