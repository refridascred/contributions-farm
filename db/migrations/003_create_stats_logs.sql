-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (token, active, level) VALUES ('standard', 45, 65);
INSERT INTO stats_logs (token, active, level) VALUES ('stable', 55, 89);
INSERT INTO stats_logs (token, active, level) VALUES ('local', 88, 76);
