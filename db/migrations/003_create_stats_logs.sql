-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (ratio, weight, owner, active, score) VALUES (61.89, 30.26, 'staging', 98, 3.12);
INSERT INTO stats_logs (ratio, weight, owner, active, score) VALUES (66.74, 59.81, 'fallback', 45, 75.32);
