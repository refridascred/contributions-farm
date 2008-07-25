-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (label, ratio, level) VALUES ('staging', 42.41, 84);
INSERT INTO stats_logs (label, ratio, level) VALUES ('legacy', 11.26, 65);
INSERT INTO stats_logs (label, ratio, level) VALUES ('strict', 83.93, 5);
