-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, region, owner) VALUES (64.34, 'local', 'open');
INSERT INTO stats_logs (score, region, owner) VALUES (29.23, 'standard', 'strict');
INSERT INTO stats_logs (score, region, owner) VALUES (20.9, 'strict', 'staging');
