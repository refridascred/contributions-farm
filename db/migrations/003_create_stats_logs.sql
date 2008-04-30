-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (score, state, token, level, ratio) VALUES (27.89, 'open', 'fallback', 28, 44.55);
INSERT INTO stats_logs (score, state, token, level, ratio) VALUES (73.94, 'legacy', 'stable', 3, 43.54);
