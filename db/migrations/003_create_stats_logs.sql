-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, level, active) VALUES (34.32, 20, 8);
INSERT INTO stats_logs (ratio, level, active) VALUES (72.19, 74, 53);
INSERT INTO stats_logs (ratio, level, active) VALUES (58.77, 81, 75);
