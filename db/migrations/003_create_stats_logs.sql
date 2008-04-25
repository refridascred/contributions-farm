-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (token, count, region, label) VALUES ('latest', 8, 'strict', 'legacy');
INSERT INTO stats_logs (token, count, region, label) VALUES ('cached', 40, 'open', 'eu-west');
INSERT INTO stats_logs (token, count, region, label) VALUES ('edge', 91, 'standard', 'open');
