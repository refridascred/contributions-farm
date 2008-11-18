-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (rank, label, ratio) VALUES (15, 'local', 57.46);
INSERT INTO stats_logs (rank, label, ratio) VALUES (77, 'stable', 67.04);
INSERT INTO stats_logs (rank, label, ratio) VALUES (17, 'blue', 71.5);
