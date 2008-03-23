-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (region, ratio, weight) VALUES ('latest', 36.91, 54.62);
INSERT INTO stats_logs (region, ratio, weight) VALUES ('strict', 59.38, 9.57);
