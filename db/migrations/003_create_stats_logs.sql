-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (ratio, token, owner, active, level) VALUES (55.71, 'primary', 'green', 97, 80);
INSERT INTO stats_logs (ratio, token, owner, active, level) VALUES (71.71, 'green', 'strict', 47, 87);
