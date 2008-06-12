-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (level, label, region) VALUES (28, 'staging', 'latest');
INSERT INTO stats_logs (level, label, region) VALUES (55, 'stable', 'green');
INSERT INTO stats_logs (level, label, region) VALUES (3, 'strict', 'open');
