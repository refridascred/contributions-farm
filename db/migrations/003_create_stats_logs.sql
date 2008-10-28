-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (label, ratio, weight) VALUES ('stable', 54.69, 66.72);
INSERT INTO stats_logs (label, ratio, weight) VALUES ('fallback', 91.66, 37.68);
INSERT INTO stats_logs (label, ratio, weight) VALUES ('latest', 17.44, 0.53);
