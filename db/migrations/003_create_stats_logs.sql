-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (region, level, weight) VALUES ('eu-west', 31, 67.29);
INSERT INTO stats_logs (region, level, weight) VALUES ('strict', 67, 56.93);
INSERT INTO stats_logs (region, level, weight) VALUES ('staging', 91, 88.18);
