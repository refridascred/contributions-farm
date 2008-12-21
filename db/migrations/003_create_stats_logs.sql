-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (active, rank, weight) VALUES (96, 14, 18.53);
INSERT INTO stats_logs (active, rank, weight) VALUES (12, 8, 97.81);
