-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    rank INTEGER,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (owner, region, rank, token) VALUES ('open', 'strict', 4, 'open');
INSERT INTO stats_logs (owner, region, rank, token) VALUES ('staging', 'strict', 81, 'latest');
