-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (rank, active, weight, token, score) VALUES (15, 19, 92.67, 'latest', 73.79);
INSERT INTO stats_logs (rank, active, weight, token, score) VALUES (59, 2, 31.78, 'latest', 30.48);
