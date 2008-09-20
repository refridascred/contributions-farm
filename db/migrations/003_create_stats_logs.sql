-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    owner TEXT NOT NULL,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (ratio, level, owner, label, region) VALUES (59.9, 39, 'edge', 'cached', 'primary');
INSERT INTO stats_logs (ratio, level, owner, label, region) VALUES (71.34, 43, 'legacy', 'local', 'eu-west');
