-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (token, ratio, level) VALUES ('strict', 49.53, 70);
INSERT INTO stats_logs (token, ratio, level) VALUES ('local', 44.67, 73);
INSERT INTO stats_logs (token, ratio, level) VALUES ('stable', 60.62, 98);
