-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (label, level, ratio, owner) VALUES ('edge', 89, 6.47, 'stable');
INSERT INTO stats_logs (label, level, ratio, owner) VALUES ('latest', 19, 4.39, 'blue');
