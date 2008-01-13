-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, score, count, region) VALUES (71, 6.12, 61, 'edge');
INSERT INTO stats_logs (active, score, count, region) VALUES (85, 79.03, 32, 'blue');
INSERT INTO stats_logs (active, score, count, region) VALUES (48, 61.98, 65, 'edge');
