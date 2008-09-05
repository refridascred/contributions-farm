-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    token TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, weight, token, rank, count) VALUES ('blue', 77.92, 'latest', 55, 38);
INSERT INTO stats_logs (region, weight, token, rank, count) VALUES ('green', 34.65, 'edge', 73, 97);
