-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (label, score, region, level) VALUES ('green', 88.18, 'cached', 29);
INSERT INTO stats_logs (label, score, region, level) VALUES ('blue', 52.9, 'local', 78);
