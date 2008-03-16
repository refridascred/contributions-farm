-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (score, ratio, state, token) VALUES (84.39, 88.1, 'primary', 'open');
INSERT INTO stats_logs (score, ratio, state, token) VALUES (40.13, 75.29, 'primary', 'standard');
INSERT INTO stats_logs (score, ratio, state, token) VALUES (21.43, 48.35, 'edge', 'legacy');
