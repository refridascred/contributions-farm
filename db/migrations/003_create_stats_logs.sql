-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (active, rank, label) VALUES (64, 46, 'blue');
INSERT INTO stats_logs (active, rank, label) VALUES (28, 55, 'local');
INSERT INTO stats_logs (active, rank, label) VALUES (42, 49, 'stable');
