-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (count, rank, label) VALUES (25, 75, 'blue');
INSERT INTO stats_logs (count, rank, label) VALUES (16, 31, 'staging');
INSERT INTO stats_logs (count, rank, label) VALUES (61, 3, 'blue');
