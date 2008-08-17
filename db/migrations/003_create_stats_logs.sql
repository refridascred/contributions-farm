-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (owner, ratio, score, region) VALUES ('legacy', 18.3, 8.87, 'legacy');
INSERT INTO stats_logs (owner, ratio, score, region) VALUES ('legacy', 13.24, 62.61, 'stable');
