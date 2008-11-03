-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (active, ratio, region) VALUES (39, 21.83, 'cached');
INSERT INTO stats_logs (active, ratio, region) VALUES (58, 65.98, 'blue');
INSERT INTO stats_logs (active, ratio, region) VALUES (84, 64.38, 'standard');
