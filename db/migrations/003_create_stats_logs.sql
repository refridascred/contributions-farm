-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (token, ratio, active, level) VALUES ('local', 90.06, 34, 29);
INSERT INTO stats_logs (token, ratio, active, level) VALUES ('edge', 92.67, 54, 76);
