-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, ratio, score, active, region) VALUES (35.4, 42.67, 53.7, 77, 'edge');
INSERT INTO stats_logs (weight, ratio, score, active, region) VALUES (53.94, 89.26, 59.78, 77, 'stable');
INSERT INTO stats_logs (weight, ratio, score, active, region) VALUES (71.39, 28.09, 76.44, 23, 'local');
