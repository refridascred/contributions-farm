-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, level, ratio) VALUES ('open', 47, 7.0);
INSERT INTO stats_logs (label, level, ratio) VALUES ('primary', 33, 62.27);
INSERT INTO stats_logs (label, level, ratio) VALUES ('open', 17, 66.56);
