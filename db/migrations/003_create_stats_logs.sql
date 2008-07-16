-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (owner, active, level) VALUES ('stable', 21, 22);
INSERT INTO stats_logs (owner, active, level) VALUES ('cached', 68, 70);
INSERT INTO stats_logs (owner, active, level) VALUES ('blue', 58, 48);
