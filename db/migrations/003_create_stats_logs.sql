-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (score, token, active, label, owner) VALUES (93.8, 'standard', 92, 'open', 'primary');
INSERT INTO stats_logs (score, token, active, label, owner) VALUES (9.98, 'latest', 38, 'fallback', 'eu-west');
INSERT INTO stats_logs (score, token, active, label, owner) VALUES (94.39, 'eu-west', 51, 'standard', 'cached');
