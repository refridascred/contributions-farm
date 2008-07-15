-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, region, label) VALUES (68.94, 'stable', 'cached');
INSERT INTO stats_logs (ratio, region, label) VALUES (58.89, 'staging', 'local');
INSERT INTO stats_logs (ratio, region, label) VALUES (34.36, 'local', 'open');
