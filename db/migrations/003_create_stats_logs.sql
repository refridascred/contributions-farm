-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (weight, score, state, token) VALUES (89.14, 78.98, 'blue', 'primary');
INSERT INTO stats_logs (weight, score, state, token) VALUES (5.95, 37.5, 'standard', 'open');
INSERT INTO stats_logs (weight, score, state, token) VALUES (93.14, 6.36, 'fallback', 'legacy');
