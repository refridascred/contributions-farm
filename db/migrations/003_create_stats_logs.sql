-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (level, token, score, state) VALUES (88, 'green', 23.42, 'fallback');
INSERT INTO stats_logs (level, token, score, state) VALUES (33, 'cached', 2.26, 'standard');
INSERT INTO stats_logs (level, token, score, state) VALUES (63, 'cached', 89.89, 'stable');
