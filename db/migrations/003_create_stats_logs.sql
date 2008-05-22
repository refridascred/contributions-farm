-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, ratio, count, weight) VALUES (13, 58.39, 60, 51.25);
INSERT INTO stats_logs (active, ratio, count, weight) VALUES (5, 82.39, 22, 64.44);
