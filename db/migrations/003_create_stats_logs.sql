-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (region, active, count, label) VALUES ('standard', 2, 30, 'cached');
INSERT INTO stats_logs (region, active, count, label) VALUES ('eu-west', 51, 53, 'edge');
INSERT INTO stats_logs (region, active, count, label) VALUES ('latest', 2, 32, 'local');
