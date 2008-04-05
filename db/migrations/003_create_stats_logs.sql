-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (weight, level, region) VALUES (14.2, 47, 'strict');
INSERT INTO stats_logs (weight, level, region) VALUES (34.5, 49, 'staging');
INSERT INTO stats_logs (weight, level, region) VALUES (98.77, 56, 'green');
