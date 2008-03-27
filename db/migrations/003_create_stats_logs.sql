-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, weight, owner, score) VALUES (39, 59.66, 'staging', 24.19);
INSERT INTO stats_logs (count, weight, owner, score) VALUES (41, 77.55, 'cached', 87.18);
INSERT INTO stats_logs (count, weight, owner, score) VALUES (48, 25.31, 'strict', 7.83);
