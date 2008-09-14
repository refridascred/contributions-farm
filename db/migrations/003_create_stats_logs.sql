-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (region, count, level, ratio) VALUES ('staging', 26, 64, 82.79);
INSERT INTO stats_logs (region, count, level, ratio) VALUES ('primary', 60, 48, 46.08);
INSERT INTO stats_logs (region, count, level, ratio) VALUES ('fallback', 38, 58, 71.63);
