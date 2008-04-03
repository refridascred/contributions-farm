-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (weight, owner, score, region) VALUES (53.34, 'legacy', 58.68, 'standard');
INSERT INTO stats_logs (weight, owner, score, region) VALUES (21.63, 'staging', 42.17, 'fallback');
