-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (active, region, score) VALUES (59, 'legacy', 41.09);
INSERT INTO stats_logs (active, region, score) VALUES (96, 'stable', 41.66);
INSERT INTO stats_logs (active, region, score) VALUES (82, 'blue', 20.77);
