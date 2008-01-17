-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (level, score, active) VALUES (80, 78.22, 64);
INSERT INTO stats_logs (level, score, active) VALUES (23, 43.75, 37);
