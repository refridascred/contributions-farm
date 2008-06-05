-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, ratio, region, level) VALUES ('green', 13.8, 'legacy', 21);
INSERT INTO stats_logs (label, ratio, region, level) VALUES ('latest', 45.66, 'fallback', 60);
