-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (state, count, level, score) VALUES ('edge', 87, 86, 20.61);
INSERT INTO stats_logs (state, count, level, score) VALUES ('open', 34, 29, 24.67);
INSERT INTO stats_logs (state, count, level, score) VALUES ('cached', 8, 99, 5.5);
