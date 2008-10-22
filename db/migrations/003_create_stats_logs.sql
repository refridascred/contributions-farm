-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    rank INTEGER,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (level, rank, weight, score) VALUES (94, 33, 25.66, 55.57);
INSERT INTO stats_logs (level, rank, weight, score) VALUES (27, 93, 88.99, 7.38);
