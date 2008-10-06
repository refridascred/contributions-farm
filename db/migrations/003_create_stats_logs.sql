-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, owner, region) VALUES (62, 'edge', 'blue');
INSERT INTO stats_logs (count, owner, region) VALUES (3, 'fallback', 'eu-west');
INSERT INTO stats_logs (count, owner, region) VALUES (66, 'eu-west', 'staging');
