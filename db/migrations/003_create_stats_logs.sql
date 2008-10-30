-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (score, active, level, region, rank) VALUES (49.34, 47, 87, 'local', 29);
INSERT INTO stats_logs (score, active, level, region, rank) VALUES (2.0, 20, 6, 'green', 43);
INSERT INTO stats_logs (score, active, level, region, rank) VALUES (89.66, 14, 64, 'primary', 75);
