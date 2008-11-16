-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, state, score) VALUES (87, 'fallback', 62.44);
INSERT INTO stats_logs (level, state, score) VALUES (8, 'standard', 42.84);
INSERT INTO stats_logs (level, state, score) VALUES (7, 'stable', 14.21);
