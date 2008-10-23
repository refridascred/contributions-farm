-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (active, region, count, level, owner) VALUES (72, 'latest', 46, 82, 'legacy');
INSERT INTO stats_logs (active, region, count, level, owner) VALUES (2, 'green', 41, 88, 'green');
