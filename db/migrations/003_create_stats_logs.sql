-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (score, active, token, owner) VALUES (2.42, 9, 'eu-west', 'edge');
INSERT INTO stats_logs (score, active, token, owner) VALUES (52.54, 18, 'cached', 'stable');
INSERT INTO stats_logs (score, active, token, owner) VALUES (81.81, 64, 'strict', 'strict');
