-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (ratio, active, state, rank, owner) VALUES (32.74, 59, 'strict', 60, 'stable');
INSERT INTO stats_logs (ratio, active, state, rank, owner) VALUES (98.19, 97, 'cached', 38, 'blue');
