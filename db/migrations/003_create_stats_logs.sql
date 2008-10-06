-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (rank, active, score, label, weight) VALUES (4, 77, 85.57, 'open', 15.43);
INSERT INTO stats_logs (rank, active, score, label, weight) VALUES (98, 39, 64.83, 'standard', 98.04);
INSERT INTO stats_logs (rank, active, score, label, weight) VALUES (94, 98, 31.74, 'stable', 54.38);
