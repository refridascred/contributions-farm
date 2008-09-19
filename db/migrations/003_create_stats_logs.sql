-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    region TEXT,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (level, ratio, region, rank, owner) VALUES (35, 37.52, 'primary', 3, 'staging');
INSERT INTO stats_logs (level, ratio, region, rank, owner) VALUES (20, 2.2, 'fallback', 45, 'eu-west');
