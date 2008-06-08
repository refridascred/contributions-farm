-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (label, active, ratio, level) VALUES ('strict', 32, 59.91, 68);
INSERT INTO stats_logs (label, active, ratio, level) VALUES ('green', 27, 19.66, 42);
