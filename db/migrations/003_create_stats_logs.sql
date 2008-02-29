-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (rank, ratio, score, count) VALUES (95, 0.63, 0.11, 40);
INSERT INTO stats_logs (rank, ratio, score, count) VALUES (71, 29.57, 5.0, 30);
INSERT INTO stats_logs (rank, ratio, score, count) VALUES (14, 25.59, 94.62, 24);
