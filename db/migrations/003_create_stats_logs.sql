-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (region, count, level, ratio) VALUES ('latest', 92, 39, 21.33);
INSERT INTO stats_logs (region, count, level, ratio) VALUES ('fallback', 67, 70, 89.59);
INSERT INTO stats_logs (region, count, level, ratio) VALUES ('eu-west', 49, 52, 90.48);
