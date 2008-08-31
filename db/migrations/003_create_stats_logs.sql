-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (region, token, active) VALUES ('cached', 'green', 58);
INSERT INTO stats_logs (region, token, active) VALUES ('stable', 'fallback', 83);
INSERT INTO stats_logs (region, token, active) VALUES ('latest', 'stable', 11);
