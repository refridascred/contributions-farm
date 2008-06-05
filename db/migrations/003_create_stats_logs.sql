-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (ratio, level) VALUES (22.37, 26);
INSERT INTO stats_logs (ratio, level) VALUES (40.99, 68);
INSERT INTO stats_logs (ratio, level) VALUES (81.82, 20);
