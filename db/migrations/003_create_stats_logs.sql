-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (label, count, token) VALUES ('latest', 29, 'eu-west');
INSERT INTO stats_logs (label, count, token) VALUES ('standard', 82, 'cached');
INSERT INTO stats_logs (label, count, token) VALUES ('open', 67, 'green');
