-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    region TEXT,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (score, region, level, label) VALUES (93.41, 'open', 0, 'local');
INSERT INTO stats_logs (score, region, level, label) VALUES (70.97, 'legacy', 47, 'primary');
INSERT INTO stats_logs (score, region, level, label) VALUES (78.28, 'legacy', 14, 'stable');
