-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (ratio, score, weight) VALUES (70.84, 53.68, 86.55);
INSERT INTO stats_logs (ratio, score, weight) VALUES (74.34, 3.89, 60.35);
