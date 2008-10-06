-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, ratio, owner) VALUES (76, 65.1, 'blue');
INSERT INTO stats_logs (level, ratio, owner) VALUES (5, 31.19, 'fallback');
INSERT INTO stats_logs (level, ratio, owner) VALUES (25, 59.24, 'cached');
