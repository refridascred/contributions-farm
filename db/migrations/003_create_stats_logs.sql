-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (count, weight, rank, score) VALUES (84, 78.02, 25, 51.83);
INSERT INTO stats_logs (count, weight, rank, score) VALUES (91, 39.19, 42, 85.2);
INSERT INTO stats_logs (count, weight, rank, score) VALUES (64, 77.76, 69, 43.74);
