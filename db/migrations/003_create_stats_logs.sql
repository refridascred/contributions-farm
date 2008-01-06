-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, owner, active, count) VALUES (38.69, 'fallback', 8, 64);
INSERT INTO stats_logs (score, owner, active, count) VALUES (78.02, 'standard', 65, 59);
INSERT INTO stats_logs (score, owner, active, count) VALUES (76.35, 'cached', 24, 12);
