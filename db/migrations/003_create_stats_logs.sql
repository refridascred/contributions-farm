-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (level, region, score, owner) VALUES (79, 'eu-west', 92.5, 'latest');
INSERT INTO stats_logs (level, region, score, owner) VALUES (16, 'standard', 67.92, 'fallback');
