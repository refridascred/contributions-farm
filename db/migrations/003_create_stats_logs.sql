-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, state, score) VALUES (20, 'blue', 71.24);
INSERT INTO stats_logs (level, state, score) VALUES (40, 'strict', 89.47);
INSERT INTO stats_logs (level, state, score) VALUES (10, 'edge', 28.44);
