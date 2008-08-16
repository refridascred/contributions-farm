-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, score, region) VALUES (11, 41.7, 'edge');
INSERT INTO stats_logs (active, score, region) VALUES (39, 35.24, 'open');
INSERT INTO stats_logs (active, score, region) VALUES (7, 64.08, 'legacy');
