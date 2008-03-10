-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    token TEXT,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, level, token, ratio, rank) VALUES ('blue', 13, 'cached', 71.74, 29);
INSERT INTO stats_logs (label, level, token, ratio, rank) VALUES ('legacy', 28, 'legacy', 20.27, 33);
INSERT INTO stats_logs (label, level, token, ratio, rank) VALUES ('staging', 38, 'open', 39.12, 95);
