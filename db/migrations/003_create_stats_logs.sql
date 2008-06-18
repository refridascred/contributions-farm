-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (active, level, count, state, score) VALUES (61, 60, 22, 'cached', 37.0);
INSERT INTO stats_logs (active, level, count, state, score) VALUES (14, 17, 75, 'latest', 80.29);
INSERT INTO stats_logs (active, level, count, state, score) VALUES (0, 60, 82, 'green', 64.83);
