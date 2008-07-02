-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    label TEXT,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (score, owner, label, rank, region) VALUES (1.43, 'fallback', 'eu-west', 93, 'blue');
INSERT INTO stats_logs (score, owner, label, rank, region) VALUES (29.72, 'blue', 'legacy', 83, 'latest');
INSERT INTO stats_logs (score, owner, label, rank, region) VALUES (32.58, 'staging', 'edge', 34, 'primary');
