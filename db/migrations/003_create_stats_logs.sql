-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (token, rank, ratio) VALUES ('local', 97, 93.8);
INSERT INTO stats_logs (token, rank, ratio) VALUES ('fallback', 42, 61.41);
