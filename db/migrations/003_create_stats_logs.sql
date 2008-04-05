-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (count, score, level, weight) VALUES (58, 93.63, 21, 36.86);
INSERT INTO stats_logs (count, score, level, weight) VALUES (20, 87.75, 28, 5.4);
