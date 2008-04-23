-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, owner, level, active) VALUES (92.27, 'open', 38, 37);
INSERT INTO stats_logs (ratio, owner, level, active) VALUES (34.47, 'strict', 30, 8);
INSERT INTO stats_logs (ratio, owner, level, active) VALUES (10.75, 'local', 30, 46);
