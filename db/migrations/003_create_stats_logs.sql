-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (region, score, owner) VALUES ('stable', 59.4, 'standard');
INSERT INTO stats_logs (region, score, owner) VALUES ('local', 59.96, 'strict');
INSERT INTO stats_logs (region, score, owner) VALUES ('staging', 69.28, 'standard');
