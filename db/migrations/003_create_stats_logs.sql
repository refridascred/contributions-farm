-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (region, score, token, ratio) VALUES ('stable', 23.97, 'staging', 66.48);
INSERT INTO stats_logs (region, score, token, ratio) VALUES ('fallback', 3.92, 'edge', 40.22);
