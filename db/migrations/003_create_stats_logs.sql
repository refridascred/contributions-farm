-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, active, region, ratio) VALUES (32.61, 48, 'legacy', 3.98);
INSERT INTO stats_logs (score, active, region, ratio) VALUES (79.61, 87, 'staging', 80.29);
