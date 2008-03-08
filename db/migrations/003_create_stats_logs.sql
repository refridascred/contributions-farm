-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (region, label, token, count) VALUES ('stable', 'eu-west', 'green', 60);
INSERT INTO stats_logs (region, label, token, count) VALUES ('staging', 'fallback', 'eu-west', 82);
