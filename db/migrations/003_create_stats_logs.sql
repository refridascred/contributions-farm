-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, active, score) VALUES ('blue', 51, 42.84);
INSERT INTO stats_logs (token, active, score) VALUES ('standard', 10, 13.96);
INSERT INTO stats_logs (token, active, score) VALUES ('strict', 88, 87.65);
