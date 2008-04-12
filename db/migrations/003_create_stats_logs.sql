-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (region, token, label, active) VALUES ('open', 'latest', 'local', 72);
INSERT INTO stats_logs (region, token, label, active) VALUES ('legacy', 'local', 'open', 45);
INSERT INTO stats_logs (region, token, label, active) VALUES ('primary', 'cached', 'edge', 38);
