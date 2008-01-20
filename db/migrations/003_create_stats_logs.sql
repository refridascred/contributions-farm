-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (score, label, owner, count, weight) VALUES (74.23, 'latest', 'legacy', 3, 39.13);
INSERT INTO stats_logs (score, label, owner, count, weight) VALUES (77.3, 'stable', 'open', 43, 64.94);
