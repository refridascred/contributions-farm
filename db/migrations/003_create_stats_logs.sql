-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (label, region) VALUES ('fallback', 'green');
INSERT INTO stats_logs (label, region) VALUES ('open', 'eu-west');
INSERT INTO stats_logs (label, region) VALUES ('edge', 'legacy');
