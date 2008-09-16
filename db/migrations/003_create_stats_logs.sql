-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (score, rank, count) VALUES (22.02, 60, 85);
INSERT INTO stats_logs (score, rank, count) VALUES (30.12, 69, 47);
INSERT INTO stats_logs (score, rank, count) VALUES (85.44, 61, 10);
