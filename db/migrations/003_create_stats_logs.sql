-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    weight REAL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (region, label, weight, level, score) VALUES ('fallback', 'green', 69.67, 19, 31.76);
INSERT INTO stats_logs (region, label, weight, level, score) VALUES ('fallback', 'staging', 20.28, 34, 83.44);
INSERT INTO stats_logs (region, label, weight, level, score) VALUES ('green', 'stable', 79.07, 73, 44.91);
