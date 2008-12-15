-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (score, count, region, owner) VALUES (2.86, 94, 'green', 'cached');
INSERT INTO stats_logs (score, count, region, owner) VALUES (97.62, 65, 'cached', 'green');
INSERT INTO stats_logs (score, count, region, owner) VALUES (43.24, 22, 'standard', 'fallback');
