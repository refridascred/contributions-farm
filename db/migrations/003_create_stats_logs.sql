-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (label, active, token, level) VALUES ('stable', 59, 'standard', 32);
INSERT INTO stats_logs (label, active, token, level) VALUES ('staging', 16, 'open', 14);
INSERT INTO stats_logs (label, active, token, level) VALUES ('latest', 77, 'green', 61);
