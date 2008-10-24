-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (weight, token, level, active) VALUES (35.63, 'latest', 88, 74);
INSERT INTO stats_logs (weight, token, level, active) VALUES (73.75, 'open', 57, 90);
INSERT INTO stats_logs (weight, token, level, active) VALUES (70.32, 'green', 18, 0);
