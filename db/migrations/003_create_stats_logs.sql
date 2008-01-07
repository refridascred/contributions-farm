-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (rank, active, ratio) VALUES (9, 42, 34.5);
INSERT INTO stats_logs (rank, active, ratio) VALUES (0, 77, 35.53);
INSERT INTO stats_logs (rank, active, ratio) VALUES (68, 9, 83.89);
