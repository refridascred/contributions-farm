-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    ratio REAL,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, level, ratio, label, region) VALUES (66.52, 72, 14.17, 'stable', 'blue');
INSERT INTO stats_logs (weight, level, ratio, label, region) VALUES (71.36, 58, 58.36, 'latest', 'staging');
