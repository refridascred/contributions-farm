-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (owner, region, score) VALUES ('legacy', 'blue', 98.02);
INSERT INTO stats_logs (owner, region, score) VALUES ('open', 'latest', 39.61);
INSERT INTO stats_logs (owner, region, score) VALUES ('strict', 'fallback', 8.28);
