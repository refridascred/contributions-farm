-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, region, owner, active) VALUES (19.37, 'latest', 'stable', 35);
INSERT INTO stats_logs (ratio, region, owner, active) VALUES (16.38, 'edge', 'blue', 37);
INSERT INTO stats_logs (ratio, region, owner, active) VALUES (18.37, 'eu-west', 'open', 40);
