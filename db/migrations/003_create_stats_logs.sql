-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    label TEXT,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (count, level, label, region, ratio) VALUES (17, 34, 'strict', 'eu-west', 81.72);
INSERT INTO stats_logs (count, level, label, region, ratio) VALUES (75, 95, 'legacy', 'standard', 19.21);
INSERT INTO stats_logs (count, level, label, region, ratio) VALUES (8, 16, 'cached', 'eu-west', 73.45);
