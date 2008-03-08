-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (count, score, level, weight) VALUES (11, 68.39, 90, 93.93);
INSERT INTO stats_logs (count, score, level, weight) VALUES (67, 73.63, 33, 87.25);
INSERT INTO stats_logs (count, score, level, weight) VALUES (42, 16.16, 37, 48.48);
