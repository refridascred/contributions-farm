-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (score, rank, active) VALUES (91.02, 3, 54);
INSERT INTO stats_logs (score, rank, active) VALUES (74.19, 16, 49);
INSERT INTO stats_logs (score, rank, active) VALUES (60.33, 41, 89);
