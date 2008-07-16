-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, level, owner) VALUES (86, 92, 'latest');
INSERT INTO stats_logs (count, level, owner) VALUES (94, 28, 'stable');
INSERT INTO stats_logs (count, level, owner) VALUES (44, 69, 'local');
