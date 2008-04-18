-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (token, region, score) VALUES ('standard', 'legacy', 53.38);
INSERT INTO stats_logs (token, region, score) VALUES ('standard', 'stable', 58.95);
INSERT INTO stats_logs (token, region, score) VALUES ('strict', 'staging', 32.89);
