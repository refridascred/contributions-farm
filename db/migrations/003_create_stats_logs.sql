-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (score, label, count, ratio) VALUES (76.3, 'legacy', 55, 75.22);
INSERT INTO stats_logs (score, label, count, ratio) VALUES (90.45, 'legacy', 7, 59.81);
INSERT INTO stats_logs (score, label, count, ratio) VALUES (17.07, 'legacy', 78, 46.51);
