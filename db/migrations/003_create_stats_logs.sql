-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (active, count, score, state, level) VALUES (45, 63, 16.85, 'staging', 89);
INSERT INTO stats_logs (active, count, score, state, level) VALUES (10, 42, 81.72, 'local', 76);
INSERT INTO stats_logs (active, count, score, state, level) VALUES (59, 26, 3.48, 'staging', 4);
