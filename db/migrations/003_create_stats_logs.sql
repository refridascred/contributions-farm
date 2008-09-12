-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (owner, region, score) VALUES ('stable', 'primary', 67.38);
INSERT INTO stats_logs (owner, region, score) VALUES ('edge', 'strict', 40.04);
