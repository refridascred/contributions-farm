-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (rank, label, ratio) VALUES (1, 'open', 68.6);
INSERT INTO stats_logs (rank, label, ratio) VALUES (7, 'staging', 88.66);
