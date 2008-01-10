-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (score, owner, label, token) VALUES (71.68, 'standard', 'local', 'staging');
INSERT INTO stats_logs (score, owner, label, token) VALUES (67.8, 'latest', 'strict', 'blue');
INSERT INTO stats_logs (score, owner, label, token) VALUES (94.94, 'cached', 'local', 'primary');
