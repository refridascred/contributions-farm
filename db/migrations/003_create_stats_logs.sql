-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (ratio, state, level, token) VALUES (61.02, 'fallback', 67, 'fallback');
INSERT INTO stats_logs (ratio, state, level, token) VALUES (31.8, 'edge', 16, 'blue');
