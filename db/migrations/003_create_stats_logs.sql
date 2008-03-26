-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (weight, state, active, token) VALUES (80.75, 'strict', 46, 'standard');
INSERT INTO stats_logs (weight, state, active, token) VALUES (51.38, 'primary', 25, 'cached');
INSERT INTO stats_logs (weight, state, active, token) VALUES (64.84, 'cached', 15, 'staging');
