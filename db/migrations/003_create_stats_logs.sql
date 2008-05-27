-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (level, active, ratio, token, count) VALUES (76, 7, 50.56, 'stable', 79);
INSERT INTO stats_logs (level, active, ratio, token, count) VALUES (19, 77, 1.14, 'green', 18);
