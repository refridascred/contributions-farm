-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (ratio, level, owner, count, weight) VALUES (77.73, 47, 'green', 13, 57.62);
INSERT INTO stats_logs (ratio, level, owner, count, weight) VALUES (73.74, 46, 'green', 86, 86.04);
