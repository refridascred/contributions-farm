-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (count, score, owner, region) VALUES (9, 66.67, 'staging', 'standard');
INSERT INTO stats_logs (count, score, owner, region) VALUES (8, 49.74, 'green', 'primary');
INSERT INTO stats_logs (count, score, owner, region) VALUES (45, 43.3, 'green', 'standard');
