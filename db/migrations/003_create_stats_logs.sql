-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (region, rank, score, active, label) VALUES ('blue', 11, 43.97, 76, 'strict');
INSERT INTO stats_logs (region, rank, score, active, label) VALUES ('edge', 90, 2.59, 88, 'primary');
INSERT INTO stats_logs (region, rank, score, active, label) VALUES ('edge', 91, 56.94, 77, 'green');
