-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (ratio, owner, active, score) VALUES (35.78, 'green', 3, 69.16);
INSERT INTO stats_logs (ratio, owner, active, score) VALUES (97.13, 'strict', 0, 51.6);
INSERT INTO stats_logs (ratio, owner, active, score) VALUES (23.15, 'blue', 65, 86.04);
