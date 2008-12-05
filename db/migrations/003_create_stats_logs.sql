-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (label, rank, weight) VALUES ('edge', 45, 64.28);
INSERT INTO stats_logs (label, rank, weight) VALUES ('local', 97, 23.89);
INSERT INTO stats_logs (label, rank, weight) VALUES ('edge', 30, 26.05);
