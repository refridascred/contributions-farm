-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    token TEXT,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (label, ratio, token, level, region) VALUES ('latest', 71.55, 'open', 32, 'latest');
INSERT INTO stats_logs (label, ratio, token, level, region) VALUES ('strict', 67.64, 'standard', 54, 'standard');
