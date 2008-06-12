-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (weight, active, token, level) VALUES (4.9, 60, 'staging', 86);
INSERT INTO stats_logs (weight, active, token, level) VALUES (90.97, 10, 'primary', 62);
