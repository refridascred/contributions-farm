-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (label, region, token) VALUES ('fallback', 'primary', 'eu-west');
INSERT INTO stats_logs (label, region, token) VALUES ('green', 'latest', 'legacy');
INSERT INTO stats_logs (label, region, token) VALUES ('fallback', 'stable', 'legacy');
