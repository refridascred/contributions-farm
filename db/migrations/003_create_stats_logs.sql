-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (score, region, rank) VALUES (28.32, 'legacy', 51);
INSERT INTO stats_logs (score, region, rank) VALUES (64.45, 'strict', 38);
INSERT INTO stats_logs (score, region, rank) VALUES (62.48, 'staging', 94);
