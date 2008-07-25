-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, token, score) VALUES ('eu-west', 'staging', 34.51);
INSERT INTO stats_logs (region, token, score) VALUES ('fallback', 'green', 66.68);
INSERT INTO stats_logs (region, token, score) VALUES ('stable', 'cached', 21.33);
