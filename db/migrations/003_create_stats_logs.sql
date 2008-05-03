-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (rank, state, ratio, weight) VALUES (86, 'eu-west', 63.68, 37.91);
INSERT INTO stats_logs (rank, state, ratio, weight) VALUES (75, 'legacy', 65.7, 19.25);
INSERT INTO stats_logs (rank, state, ratio, weight) VALUES (99, 'stable', 15.51, 24.36);
