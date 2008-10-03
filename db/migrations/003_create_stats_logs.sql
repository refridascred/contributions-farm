-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    owner TEXT NOT NULL,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (active, ratio, owner, level, weight) VALUES (93, 62.5, 'green', 40, 25.27);
INSERT INTO stats_logs (active, ratio, owner, level, weight) VALUES (42, 40.98, 'fallback', 72, 48.86);
INSERT INTO stats_logs (active, ratio, owner, level, weight) VALUES (52, 31.83, 'latest', 32, 52.06);
