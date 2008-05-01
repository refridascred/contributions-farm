-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, level, state, token, ratio) VALUES (80.22, 46, 'fallback', 'edge', 32.82);
INSERT INTO stats_logs (score, level, state, token, ratio) VALUES (35.76, 93, 'staging', 'edge', 7.54);
