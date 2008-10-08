-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (count, score, owner, weight, region) VALUES (87, 12.99, 'strict', 16.2, 'primary');
INSERT INTO stats_logs (count, score, owner, weight, region) VALUES (78, 84.2, 'fallback', 78.95, 'stable');
