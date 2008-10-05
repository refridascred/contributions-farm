-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (score, owner, region) VALUES (35.62, 'edge', 'fallback');
INSERT INTO stats_logs (score, owner, region) VALUES (27.85, 'blue', 'open');
