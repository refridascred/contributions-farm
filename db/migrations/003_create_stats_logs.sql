-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (level, ratio, weight) VALUES (15, 58.64, 28.99);
INSERT INTO stats_logs (level, ratio, weight) VALUES (52, 97.64, 58.91);
