-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (ratio, weight, rank, active, state) VALUES (35.48, 70.29, 59, 77, 'green');
INSERT INTO stats_logs (ratio, weight, rank, active, state) VALUES (34.38, 21.19, 89, 4, 'latest');
