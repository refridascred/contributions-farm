-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (owner, score, rank, region) VALUES ('strict', 83.67, 2, 'strict');
INSERT INTO stats_logs (owner, score, rank, region) VALUES ('legacy', 53.51, 55, 'staging');
INSERT INTO stats_logs (owner, score, rank, region) VALUES ('latest', 53.68, 16, 'latest');
