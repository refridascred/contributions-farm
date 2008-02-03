-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, count, ratio, score, owner) VALUES ('green', 70, 38.61, 72.83, 'blue');
INSERT INTO stats_logs (region, count, ratio, score, owner) VALUES ('legacy', 74, 15.19, 45.06, 'edge');
