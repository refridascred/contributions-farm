-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (token, ratio, level, count) VALUES ('fallback', 85.08, 62, 81);
INSERT INTO stats_logs (token, ratio, level, count) VALUES ('staging', 98.46, 55, 37);
INSERT INTO stats_logs (token, ratio, level, count) VALUES ('strict', 61.23, 94, 22);
