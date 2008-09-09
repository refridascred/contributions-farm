-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (ratio, active, score, owner) VALUES (23.08, 75, 82.2, 'primary');
INSERT INTO stats_logs (ratio, active, score, owner) VALUES (50.18, 22, 57.33, 'eu-west');
