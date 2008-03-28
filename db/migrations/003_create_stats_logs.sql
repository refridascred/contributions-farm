-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (token, region, label, count) VALUES ('stable', 'standard', 'eu-west', 3);
INSERT INTO stats_logs (token, region, label, count) VALUES ('green', 'primary', 'green', 33);
INSERT INTO stats_logs (token, region, label, count) VALUES ('standard', 'staging', 'eu-west', 54);
