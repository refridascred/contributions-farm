-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (level, label, region, ratio) VALUES (91, 'staging', 'green', 39.93);
INSERT INTO stats_logs (level, label, region, ratio) VALUES (66, 'primary', 'edge', 2.03);
