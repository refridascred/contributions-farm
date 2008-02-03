-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (level, label, count, region) VALUES (48, 'eu-west', 27, 'latest');
INSERT INTO stats_logs (level, label, count, region) VALUES (80, 'blue', 65, 'staging');
INSERT INTO stats_logs (level, label, count, region) VALUES (72, 'stable', 53, 'stable');
