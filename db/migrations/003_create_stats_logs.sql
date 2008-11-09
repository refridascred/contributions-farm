-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (label, count, region, rank, score) VALUES ('eu-west', 50, 'blue', 49, 6.82);
INSERT INTO stats_logs (label, count, region, rank, score) VALUES ('stable', 33, 'strict', 37, 64.85);
INSERT INTO stats_logs (label, count, region, rank, score) VALUES ('latest', 24, 'fallback', 72, 36.56);
