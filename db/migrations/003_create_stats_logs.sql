-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (label, region, score) VALUES ('latest', 'strict', 6.58);
INSERT INTO stats_logs (label, region, score) VALUES ('latest', 'stable', 48.91);
INSERT INTO stats_logs (label, region, score) VALUES ('fallback', 'stable', 68.21);
