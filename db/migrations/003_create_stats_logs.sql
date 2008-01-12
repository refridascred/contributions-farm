-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (ratio, score, owner) VALUES (2.36, 36.86, 'standard');
INSERT INTO stats_logs (ratio, score, owner) VALUES (46.38, 54.72, 'stable');
INSERT INTO stats_logs (ratio, score, owner) VALUES (79.95, 52.28, 'open');
