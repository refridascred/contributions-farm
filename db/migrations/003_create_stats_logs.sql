-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (level, owner, region) VALUES (37, 'cached', 'standard');
INSERT INTO stats_logs (level, owner, region) VALUES (3, 'edge', 'edge');
INSERT INTO stats_logs (level, owner, region) VALUES (39, 'open', 'stable');
