-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (region, score, count, ratio) VALUES ('local', 87.24, 86, 89.32);
INSERT INTO stats_logs (region, score, count, ratio) VALUES ('staging', 34.83, 59, 73.36);
INSERT INTO stats_logs (region, score, count, ratio) VALUES ('green', 66.25, 80, 55.16);
