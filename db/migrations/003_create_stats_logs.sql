-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (label, token, count) VALUES ('latest', 'latest', 54);
INSERT INTO stats_logs (label, token, count) VALUES ('standard', 'strict', 32);
INSERT INTO stats_logs (label, token, count) VALUES ('edge', 'strict', 53);
