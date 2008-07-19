-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, active, owner) VALUES (40.91, 76, 'standard');
INSERT INTO stats_logs (ratio, active, owner) VALUES (58.04, 32, 'primary');
INSERT INTO stats_logs (ratio, active, owner) VALUES (67.72, 83, 'primary');
