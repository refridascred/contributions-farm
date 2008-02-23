-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    rank INTEGER,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (owner, region, rank, weight, level) VALUES ('fallback', 'open', 46, 8.66, 57);
INSERT INTO stats_logs (owner, region, rank, weight, level) VALUES ('green', 'staging', 95, 95.59, 83);
