-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (rank, active, token, weight, count) VALUES (33, 43, 'staging', 35.32, 73);
INSERT INTO stats_logs (rank, active, token, weight, count) VALUES (2, 75, 'local', 28.19, 19);
INSERT INTO stats_logs (rank, active, token, weight, count) VALUES (82, 28, 'strict', 75.84, 6);
