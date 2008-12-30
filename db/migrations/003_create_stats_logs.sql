-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (token, score, active) VALUES ('strict', 75.92, 19);
INSERT INTO stats_logs (token, score, active) VALUES ('edge', 33.91, 69);
INSERT INTO stats_logs (token, score, active) VALUES ('open', 76.49, 16);
