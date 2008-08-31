-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (owner, ratio, count, region) VALUES ('local', 13.75, 26, 'latest');
INSERT INTO stats_logs (owner, ratio, count, region) VALUES ('green', 53.0, 4, 'open');
INSERT INTO stats_logs (owner, ratio, count, region) VALUES ('green', 8.22, 21, 'eu-west');
