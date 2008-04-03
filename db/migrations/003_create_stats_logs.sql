-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (score, state, token) VALUES (58.03, 'latest', 'standard');
INSERT INTO stats_logs (score, state, token) VALUES (43.53, 'staging', 'primary');
INSERT INTO stats_logs (score, state, token) VALUES (0.43, 'latest', 'fallback');
