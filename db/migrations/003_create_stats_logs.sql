-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (rank, token, ratio, score) VALUES (85, 'eu-west', 13.51, 55.01);
INSERT INTO stats_logs (rank, token, ratio, score) VALUES (15, 'primary', 15.91, 38.07);
INSERT INTO stats_logs (rank, token, ratio, score) VALUES (74, 'green', 98.0, 78.11);
