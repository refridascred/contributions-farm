-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (label, score, level, region, owner) VALUES ('edge', 56.98, 83, 'stable', 'green');
INSERT INTO stats_logs (label, score, level, region, owner) VALUES ('cached', 47.15, 46, 'green', 'strict');
