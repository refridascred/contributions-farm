-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (active, rank) VALUES (62, 30);
INSERT INTO stats_logs (active, rank) VALUES (76, 70);
INSERT INTO stats_logs (active, rank) VALUES (39, 64);
