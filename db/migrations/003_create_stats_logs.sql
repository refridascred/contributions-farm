-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (ratio, region, token, count) VALUES (96.93, 'staging', 'latest', 55);
INSERT INTO stats_logs (ratio, region, token, count) VALUES (52.62, 'eu-west', 'edge', 1);
