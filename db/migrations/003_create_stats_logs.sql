-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (level, ratio, active) VALUES (81, 31.89, 89);
INSERT INTO stats_logs (level, ratio, active) VALUES (12, 89.17, 75);
INSERT INTO stats_logs (level, ratio, active) VALUES (70, 37.89, 94);
