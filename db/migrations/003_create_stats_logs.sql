-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (level, state, token) VALUES (82, 'staging', 'local');
INSERT INTO stats_logs (level, state, token) VALUES (78, 'blue', 'open');
INSERT INTO stats_logs (level, state, token) VALUES (33, 'standard', 'cached');
