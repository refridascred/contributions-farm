-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (region, level, ratio, active) VALUES ('open', 81, 92.27, 97);
INSERT INTO stats_logs (region, level, ratio, active) VALUES ('staging', 95, 58.85, 75);
INSERT INTO stats_logs (region, level, ratio, active) VALUES ('primary', 81, 46.58, 0);
