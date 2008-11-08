-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (rank, active, ratio, state, weight) VALUES (24, 95, 63.54, 'edge', 88.0);
INSERT INTO stats_logs (rank, active, ratio, state, weight) VALUES (44, 48, 61.16, 'blue', 98.77);
INSERT INTO stats_logs (rank, active, ratio, state, weight) VALUES (27, 7, 87.75, 'cached', 27.11);
