-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (label, region, token, score) VALUES ('strict', 'fallback', 'legacy', 89.71);
INSERT INTO stats_logs (label, region, token, score) VALUES ('stable', 'eu-west', 'staging', 59.81);
INSERT INTO stats_logs (label, region, token, score) VALUES ('legacy', 'eu-west', 'eu-west', 6.02);
