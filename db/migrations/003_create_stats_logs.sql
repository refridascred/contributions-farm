-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (weight, owner, active, rank, state) VALUES (29.33, 'latest', 32, 82, 'local');
INSERT INTO stats_logs (weight, owner, active, rank, state) VALUES (47.9, 'legacy', 35, 79, 'standard');
