-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (weight, ratio, rank, score, count) VALUES (84.52, 69.47, 64, 43.45, 69);
INSERT INTO stats_logs (weight, ratio, rank, score, count) VALUES (56.7, 59.34, 48, 48.2, 47);
INSERT INTO stats_logs (weight, ratio, rank, score, count) VALUES (25.66, 12.13, 47, 12.89, 6);
