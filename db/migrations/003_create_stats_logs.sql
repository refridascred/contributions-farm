-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (label, weight, level) VALUES ('legacy', 27.85, 31);
INSERT INTO stats_logs (label, weight, level) VALUES ('cached', 79.14, 74);
INSERT INTO stats_logs (label, weight, level) VALUES ('legacy', 58.68, 94);
