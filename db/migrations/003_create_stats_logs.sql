-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (label, owner, count, rank, region) VALUES ('strict', 'edge', 45, 59, 'strict');
INSERT INTO stats_logs (label, owner, count, rank, region) VALUES ('blue', 'strict', 13, 18, 'edge');
INSERT INTO stats_logs (label, owner, count, rank, region) VALUES ('fallback', 'edge', 76, 38, 'stable');
