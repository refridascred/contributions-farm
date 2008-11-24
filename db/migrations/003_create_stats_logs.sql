-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (region, rank, count, active) VALUES ('eu-west', 21, 32, 38);
INSERT INTO stats_logs (region, rank, count, active) VALUES ('blue', 70, 65, 24);
