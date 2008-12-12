-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, count, region, label) VALUES (94, 30, 'eu-west', 'primary');
INSERT INTO stats_logs (level, count, region, label) VALUES (57, 76, 'standard', 'strict');
