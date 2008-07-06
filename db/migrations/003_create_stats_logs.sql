-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (count, ratio, weight, score, rank) VALUES (72, 37.44, 28.11, 47.05, 55);
INSERT INTO stats_logs (count, ratio, weight, score, rank) VALUES (64, 79.01, 79.68, 3.57, 48);
INSERT INTO stats_logs (count, ratio, weight, score, rank) VALUES (4, 46.27, 33.28, 63.13, 42);
