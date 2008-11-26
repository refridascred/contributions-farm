-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (region, ratio, score, label) VALUES ('open', 54.36, 58.22, 'fallback');
INSERT INTO stats_logs (region, ratio, score, label) VALUES ('strict', 72.54, 96.24, 'fallback');
