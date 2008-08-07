-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (active, count, label, weight, ratio) VALUES (51, 70, 'latest', 52.0, 65.78);
INSERT INTO stats_logs (active, count, label, weight, ratio) VALUES (4, 58, 'fallback', 82.84, 70.56);
