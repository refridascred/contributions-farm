-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (region, label, count) VALUES ('edge', 'legacy', 60);
INSERT INTO stats_logs (region, label, count) VALUES ('open', 'standard', 97);
INSERT INTO stats_logs (region, label, count) VALUES ('edge', 'stable', 94);
