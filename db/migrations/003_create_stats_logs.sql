-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    weight REAL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, rank, weight, region, count) VALUES ('local', 32, 47.74, 'latest', 45);
INSERT INTO stats_logs (token, rank, weight, region, count) VALUES ('legacy', 73, 55.96, 'blue', 77);
INSERT INTO stats_logs (token, rank, weight, region, count) VALUES ('blue', 39, 20.9, 'local', 17);
