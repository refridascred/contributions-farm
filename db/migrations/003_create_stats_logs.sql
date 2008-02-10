-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (ratio, owner, label, count) VALUES (6.43, 'edge', 'staging', 66);
INSERT INTO stats_logs (ratio, owner, label, count) VALUES (55.11, 'cached', 'edge', 61);
INSERT INTO stats_logs (ratio, owner, label, count) VALUES (82.31, 'fallback', 'blue', 77);
