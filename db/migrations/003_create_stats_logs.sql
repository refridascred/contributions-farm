-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (rank, count, ratio, score, weight) VALUES (40, 99, 76.11, 78.23, 42.7);
INSERT INTO stats_logs (rank, count, ratio, score, weight) VALUES (42, 81, 5.61, 53.27, 64.95);
