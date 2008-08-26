-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (rank, weight, score, owner) VALUES (14, 89.71, 57.43, 'edge');
INSERT INTO stats_logs (rank, weight, score, owner) VALUES (79, 71.03, 90.61, 'stable');
INSERT INTO stats_logs (rank, weight, score, owner) VALUES (92, 13.39, 25.29, 'primary');
