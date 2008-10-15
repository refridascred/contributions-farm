-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (token, ratio, rank, active, score) VALUES ('blue', 6.63, 62, 50, 21.78);
INSERT INTO stats_logs (token, ratio, rank, active, score) VALUES ('stable', 80.5, 18, 4, 53.16);
