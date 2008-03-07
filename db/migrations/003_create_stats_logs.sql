-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (token, label, region) VALUES ('edge', 'legacy', 'blue');
INSERT INTO stats_logs (token, label, region) VALUES ('stable', 'primary', 'latest');
INSERT INTO stats_logs (token, label, region) VALUES ('fallback', 'latest', 'legacy');
