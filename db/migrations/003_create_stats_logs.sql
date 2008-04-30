-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (count, region, owner, label) VALUES (26, 'latest', 'fallback', 'legacy');
INSERT INTO stats_logs (count, region, owner, label) VALUES (8, 'edge', 'latest', 'latest');
INSERT INTO stats_logs (count, region, owner, label) VALUES (31, 'open', 'blue', 'cached');
