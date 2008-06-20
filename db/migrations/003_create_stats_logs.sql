-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, weight, active, score) VALUES ('green', 20.13, 25, 28.96);
INSERT INTO stats_logs (token, weight, active, score) VALUES ('eu-west', 31.94, 72, 40.04);
