-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (ratio, weight, score, region) VALUES (42.15, 38.48, 68.0, 'open');
INSERT INTO stats_logs (ratio, weight, score, region) VALUES (27.74, 94.71, 23.22, 'fallback');
