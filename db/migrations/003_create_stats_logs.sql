-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (region, token, rank, count) VALUES ('local', 'latest', 70, 46);
INSERT INTO stats_logs (region, token, rank, count) VALUES ('staging', 'latest', 95, 36);
