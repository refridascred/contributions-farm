-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, level, region) VALUES (10.63, 28, 'standard');
INSERT INTO stats_logs (weight, level, region) VALUES (63.35, 49, 'staging');
INSERT INTO stats_logs (weight, level, region) VALUES (63.51, 65, 'standard');
