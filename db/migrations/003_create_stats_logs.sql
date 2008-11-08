-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, score, rank, token) VALUES (60.02, 51.37, 87, 'standard');
INSERT INTO stats_logs (ratio, score, rank, token) VALUES (2.23, 4.59, 76, 'edge');
INSERT INTO stats_logs (ratio, score, rank, token) VALUES (39.81, 17.21, 30, 'legacy');
