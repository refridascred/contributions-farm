-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (level, count, region, weight, label) VALUES (79, 14, 'edge', 67.46, 'stable');
INSERT INTO stats_logs (level, count, region, weight, label) VALUES (92, 53, 'open', 61.49, 'green');
