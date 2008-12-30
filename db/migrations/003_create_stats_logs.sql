-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (label, level, region, ratio) VALUES ('eu-west', 14, 'cached', 25.43);
INSERT INTO stats_logs (label, level, region, ratio) VALUES ('strict', 67, 'edge', 60.2);
