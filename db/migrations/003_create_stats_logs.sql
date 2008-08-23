-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    token TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, owner, token, weight, score) VALUES (84.16, 'latest', 'legacy', 0.08, 76.29);
INSERT INTO stats_logs (ratio, owner, token, weight, score) VALUES (27.85, 'legacy', 'blue', 56.74, 29.86);
INSERT INTO stats_logs (ratio, owner, token, weight, score) VALUES (44.59, 'latest', 'eu-west', 46.92, 32.53);
