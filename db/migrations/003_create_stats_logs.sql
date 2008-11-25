-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (weight, region, token) VALUES (53.59, 'green', 'green');
INSERT INTO stats_logs (weight, region, token) VALUES (0.68, 'primary', 'latest');
INSERT INTO stats_logs (weight, region, token) VALUES (76.15, 'local', 'latest');
