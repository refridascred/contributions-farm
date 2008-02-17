-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (label, active, rank) VALUES ('latest', 79, 44);
INSERT INTO stats_logs (label, active, rank) VALUES ('cached', 41, 19);
INSERT INTO stats_logs (label, active, rank) VALUES ('green', 38, 98);
