-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (token, label, region, count) VALUES ('standard', 'edge', 'open', 81);
INSERT INTO stats_logs (token, label, region, count) VALUES ('stable', 'stable', 'stable', 71);
