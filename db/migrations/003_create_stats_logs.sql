-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    region TEXT,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (score, rank, region, token, ratio) VALUES (24.4, 96, 'standard', 'green', 63.99);
INSERT INTO stats_logs (score, rank, region, token, ratio) VALUES (55.46, 10, 'eu-west', 'eu-west', 88.33);
