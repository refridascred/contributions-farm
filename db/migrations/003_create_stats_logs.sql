-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (token, count, rank, region) VALUES ('eu-west', 82, 86, 'staging');
INSERT INTO stats_logs (token, count, rank, region) VALUES ('eu-west', 65, 83, 'local');
