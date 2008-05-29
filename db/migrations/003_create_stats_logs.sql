-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    weight REAL,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (count, level, weight, owner, ratio) VALUES (83, 65, 4.99, 'local', 47.4);
INSERT INTO stats_logs (count, level, weight, owner, ratio) VALUES (72, 44, 40.88, 'blue', 85.89);
