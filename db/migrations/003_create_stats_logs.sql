-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (label, level, ratio) VALUES ('strict', 98, 13.43);
INSERT INTO stats_logs (label, level, ratio) VALUES ('legacy', 48, 97.81);
INSERT INTO stats_logs (label, level, ratio) VALUES ('local', 35, 47.52);
