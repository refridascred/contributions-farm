-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (level, score, owner, ratio) VALUES (86, 77.45, 'staging', 65.89);
INSERT INTO stats_logs (level, score, owner, ratio) VALUES (74, 89.33, 'fallback', 47.91);
