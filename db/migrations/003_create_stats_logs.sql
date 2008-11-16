-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (active, ratio, count) VALUES (48, 55.98, 48);
INSERT INTO stats_logs (active, ratio, count) VALUES (67, 28.51, 10);
INSERT INTO stats_logs (active, ratio, count) VALUES (89, 95.95, 13);
