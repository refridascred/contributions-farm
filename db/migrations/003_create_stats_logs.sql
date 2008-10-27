-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (owner, ratio, region) VALUES ('stable', 5.76, 'standard');
INSERT INTO stats_logs (owner, ratio, region) VALUES ('green', 49.06, 'open');
INSERT INTO stats_logs (owner, ratio, region) VALUES ('staging', 60.65, 'latest');
