-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    owner TEXT NOT NULL,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (ratio, level, owner, region, token) VALUES (80.44, 1, 'local', 'staging', 'staging');
INSERT INTO stats_logs (ratio, level, owner, region, token) VALUES (49.75, 33, 'cached', 'primary', 'green');
INSERT INTO stats_logs (ratio, level, owner, region, token) VALUES (35.68, 73, 'cached', 'strict', 'edge');
