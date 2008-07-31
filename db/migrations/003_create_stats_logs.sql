-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (active, token, label, owner) VALUES (80, 'primary', 'latest', 'legacy');
INSERT INTO stats_logs (active, token, label, owner) VALUES (76, 'staging', 'eu-west', 'primary');
INSERT INTO stats_logs (active, token, label, owner) VALUES (48, 'green', 'strict', 'legacy');
