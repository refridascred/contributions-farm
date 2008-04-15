-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, owner, score) VALUES (82.18, 'strict', 79.18);
INSERT INTO stats_logs (ratio, owner, score) VALUES (47.87, 'cached', 20.0);
INSERT INTO stats_logs (ratio, owner, score) VALUES (6.53, 'standard', 52.62);
