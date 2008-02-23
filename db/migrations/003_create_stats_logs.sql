-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    region TEXT,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (rank, level, region, ratio, label) VALUES (42, 54, 'open', 36.43, 'eu-west');
INSERT INTO stats_logs (rank, level, region, ratio, label) VALUES (89, 22, 'green', 86.57, 'green');
