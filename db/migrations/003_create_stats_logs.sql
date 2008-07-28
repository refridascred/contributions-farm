-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    weight REAL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (rank, token, weight, level, active) VALUES (4, 'latest', 59.68, 0, 93);
INSERT INTO stats_logs (rank, token, weight, level, active) VALUES (48, 'green', 57.93, 92, 70);
INSERT INTO stats_logs (rank, token, weight, level, active) VALUES (19, 'fallback', 72.85, 82, 79);
