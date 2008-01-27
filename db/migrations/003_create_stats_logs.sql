-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (ratio, owner, level) VALUES (49.63, 'local', 62);
INSERT INTO stats_logs (ratio, owner, level) VALUES (51.07, 'local', 94);
INSERT INTO stats_logs (ratio, owner, level) VALUES (20.31, 'cached', 7);
