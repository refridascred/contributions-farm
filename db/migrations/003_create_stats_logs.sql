-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (count, score, active) VALUES (51, 58.63, 35);
INSERT INTO stats_logs (count, score, active) VALUES (76, 72.65, 1);
INSERT INTO stats_logs (count, score, active) VALUES (1, 39.1, 82);
