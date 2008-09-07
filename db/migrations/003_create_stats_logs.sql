-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (ratio, label, owner, region) VALUES (68.92, 'green', 'fallback', 'open');
INSERT INTO stats_logs (ratio, label, owner, region) VALUES (93.78, 'edge', 'open', 'blue');
