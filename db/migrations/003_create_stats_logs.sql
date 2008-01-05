-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    region TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (count, ratio, region, owner) VALUES (55, 11.68, 'legacy', 'edge');
INSERT INTO stats_logs (count, ratio, region, owner) VALUES (83, 43.58, 'edge', 'blue');
