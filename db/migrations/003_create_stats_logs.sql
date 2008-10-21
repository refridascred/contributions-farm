-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (rank, ratio, state, level, count) VALUES (78, 23.07, 'latest', 29, 18);
INSERT INTO stats_logs (rank, ratio, state, level, count) VALUES (48, 7.59, 'stable', 33, 15);
