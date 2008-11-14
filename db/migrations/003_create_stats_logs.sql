-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    region TEXT,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (level, label, region, token, owner) VALUES (54, 'blue', 'edge', 'blue', 'primary');
INSERT INTO stats_logs (level, label, region, token, owner) VALUES (5, 'staging', 'latest', 'cached', 'fallback');
INSERT INTO stats_logs (level, label, region, token, owner) VALUES (16, 'eu-west', 'cached', 'eu-west', 'legacy');
