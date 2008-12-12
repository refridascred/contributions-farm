-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (level, region, label, ratio) VALUES (17, 'staging', 'strict', 73.47);
INSERT INTO stats_logs (level, region, label, ratio) VALUES (91, 'edge', 'edge', 81.89);
