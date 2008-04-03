-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (score, level, active, region) VALUES (98.35, 81, 21, 'latest');
INSERT INTO stats_logs (score, level, active, region) VALUES (45.53, 85, 72, 'cached');
INSERT INTO stats_logs (score, level, active, region) VALUES (70.67, 89, 6, 'green');
