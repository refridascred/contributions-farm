-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (active, ratio, count, rank, score) VALUES (29, 18.54, 64, 80, 37.31);
INSERT INTO stats_logs (active, ratio, count, rank, score) VALUES (74, 40.97, 44, 92, 40.78);
INSERT INTO stats_logs (active, ratio, count, rank, score) VALUES (2, 89.19, 57, 70, 16.72);
