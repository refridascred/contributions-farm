-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, region, label) VALUES (17, 'edge', 'edge');
INSERT INTO stats_logs (level, region, label) VALUES (72, 'eu-west', 'latest');
INSERT INTO stats_logs (level, region, label) VALUES (82, 'stable', 'eu-west');
