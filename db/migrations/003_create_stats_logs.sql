-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (rank, ratio, weight, state, count) VALUES (95, 64.98, 97.76, 'staging', 24);
INSERT INTO stats_logs (rank, ratio, weight, state, count) VALUES (47, 85.47, 8.89, 'staging', 78);
INSERT INTO stats_logs (rank, ratio, weight, state, count) VALUES (26, 0.97, 74.14, 'legacy', 18);
