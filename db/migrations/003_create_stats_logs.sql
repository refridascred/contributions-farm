-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (weight, active, label, rank) VALUES (21.77, 56, 'staging', 95);
INSERT INTO stats_logs (weight, active, label, rank) VALUES (22.63, 41, 'local', 46);
