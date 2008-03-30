-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (token, region, owner, score) VALUES ('blue', 'staging', 'legacy', 4.41);
INSERT INTO stats_logs (token, region, owner, score) VALUES ('fallback', 'standard', 'staging', 36.67);
INSERT INTO stats_logs (token, region, owner, score) VALUES ('blue', 'eu-west', 'staging', 3.09);
