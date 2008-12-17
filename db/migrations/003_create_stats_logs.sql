-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (token, active, level) VALUES ('standard', 25, 17);
INSERT INTO stats_logs (token, active, level) VALUES ('legacy', 22, 5);
INSERT INTO stats_logs (token, active, level) VALUES ('staging', 11, 67);
