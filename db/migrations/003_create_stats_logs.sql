-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (level, ratio, active, weight) VALUES (23, 51.46, 27, 57.47);
INSERT INTO stats_logs (level, ratio, active, weight) VALUES (10, 98.87, 4, 20.38);
