-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (score, active, count, label, ratio) VALUES (75.67, 54, 27, 'strict', 85.33);
INSERT INTO stats_logs (score, active, count, label, ratio) VALUES (45.29, 88, 56, 'fallback', 88.65);
