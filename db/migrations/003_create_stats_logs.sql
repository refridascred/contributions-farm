-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (score, label, weight, count) VALUES (25.76, 'fallback', 15.73, 15);
INSERT INTO stats_logs (score, label, weight, count) VALUES (61.15, 'stable', 14.35, 68);
