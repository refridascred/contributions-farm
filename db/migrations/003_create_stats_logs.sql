-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (score, level, active, region) VALUES (54.02, 15, 43, 'staging');
INSERT INTO stats_logs (score, level, active, region) VALUES (77.17, 20, 44, 'stable');
INSERT INTO stats_logs (score, level, active, region) VALUES (40.99, 88, 49, 'standard');
