-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (level, label, state, token, score) VALUES (99, 'cached', 'latest', 'legacy', 41.0);
INSERT INTO stats_logs (level, label, state, token, score) VALUES (96, 'local', 'latest', 'primary', 56.97);
INSERT INTO stats_logs (level, label, state, token, score) VALUES (69, 'legacy', 'cached', 'standard', 63.0);
