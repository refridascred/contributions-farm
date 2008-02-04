-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    token TEXT,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (state, token, weight, active) VALUES ('primary', 'fallback', 78.8, 57);
INSERT INTO stats_logs (state, token, weight, active) VALUES ('open', 'stable', 58.82, 42);
INSERT INTO stats_logs (state, token, weight, active) VALUES ('local', 'fallback', 52.18, 47);
