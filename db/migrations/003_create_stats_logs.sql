-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, score, token, count) VALUES (14.99, 81.69, 'latest', 50);
INSERT INTO stats_logs (ratio, score, token, count) VALUES (81.6, 26.99, 'cached', 40);
INSERT INTO stats_logs (ratio, score, token, count) VALUES (16.64, 27.52, 'primary', 23);
