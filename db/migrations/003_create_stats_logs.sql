-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (score, active, count) VALUES (2.98, 1, 40);
INSERT INTO stats_logs (score, active, count) VALUES (83.31, 99, 31);
INSERT INTO stats_logs (score, active, count) VALUES (61.06, 68, 15);
