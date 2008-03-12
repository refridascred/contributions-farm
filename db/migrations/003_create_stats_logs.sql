-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (weight, level, token, active) VALUES (53.6, 61, 'staging', 84);
INSERT INTO stats_logs (weight, level, token, active) VALUES (3.15, 39, 'stable', 16);
INSERT INTO stats_logs (weight, level, token, active) VALUES (87.69, 43, 'green', 76);
