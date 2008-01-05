-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    ratio REAL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (count, level, ratio, rank, state) VALUES (65, 9, 27.14, 70, 'local');
INSERT INTO stats_logs (count, level, ratio, rank, state) VALUES (52, 97, 64.71, 30, 'strict');
