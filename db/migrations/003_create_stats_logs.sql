-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (score, level, active) VALUES (61.92, 41, 27);
INSERT INTO stats_logs (score, level, active) VALUES (50.7, 84, 0);
INSERT INTO stats_logs (score, level, active) VALUES (49.85, 37, 63);
