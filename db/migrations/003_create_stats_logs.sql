-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, weight, label, owner) VALUES (84.28, 12.46, 'legacy', 'edge');
INSERT INTO stats_logs (score, weight, label, owner) VALUES (51.36, 1.08, 'staging', 'stable');
