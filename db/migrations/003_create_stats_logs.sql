-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (rank, label, level, score, region) VALUES (63, 'latest', 56, 25.92, 'edge');
INSERT INTO stats_logs (rank, label, level, score, region) VALUES (1, 'fallback', 43, 10.95, 'latest');
