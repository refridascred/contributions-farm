-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (owner, count, region, token) VALUES ('staging', 45, 'latest', 'blue');
INSERT INTO stats_logs (owner, count, region, token) VALUES ('local', 78, 'local', 'cached');
INSERT INTO stats_logs (owner, count, region, token) VALUES ('primary', 5, 'green', 'primary');
