-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (level, token, weight, region) VALUES (84, 'cached', 83.24, 'green');
INSERT INTO stats_logs (level, token, weight, region) VALUES (1, 'staging', 79.13, 'latest');
