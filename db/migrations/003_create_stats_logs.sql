-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (owner, count, region) VALUES ('cached', 32, 'staging');
INSERT INTO stats_logs (owner, count, region) VALUES ('legacy', 48, 'stable');
INSERT INTO stats_logs (owner, count, region) VALUES ('legacy', 23, 'green');
