-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    rank INTEGER,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (active, level, rank, ratio, owner) VALUES (50, 58, 74, 32.82, 'local');
INSERT INTO stats_logs (active, level, rank, ratio, owner) VALUES (55, 77, 67, 74.25, 'latest');
