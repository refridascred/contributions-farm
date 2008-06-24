-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, label, owner) VALUES ('strict', 'latest', 'fallback');
INSERT INTO stats_logs (token, label, owner) VALUES ('latest', 'staging', 'eu-west');
INSERT INTO stats_logs (token, label, owner) VALUES ('open', 'fallback', 'cached');
