-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, weight, owner, score) VALUES (16, 46.71, 'cached', 30.64);
INSERT INTO stats_logs (level, weight, owner, score) VALUES (81, 22.31, 'open', 18.99);
