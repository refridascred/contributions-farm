-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, level, count) VALUES ('open', 81, 81);
INSERT INTO stats_logs (label, level, count) VALUES ('standard', 49, 76);
INSERT INTO stats_logs (label, level, count) VALUES ('cached', 66, 74);
