-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    rank INTEGER,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (label, owner, rank, ratio, score) VALUES ('edge', 'blue', 2, 31.33, 67.27);
INSERT INTO stats_logs (label, owner, rank, ratio, score) VALUES ('open', 'legacy', 53, 50.29, 8.32);
INSERT INTO stats_logs (label, owner, rank, ratio, score) VALUES ('open', 'primary', 92, 36.26, 47.77);
