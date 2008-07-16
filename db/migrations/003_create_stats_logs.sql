-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (count, token, ratio, score, active) VALUES (79, 'primary', 4.33, 46.98, 12);
INSERT INTO stats_logs (count, token, ratio, score, active) VALUES (50, 'green', 26.44, 97.39, 52);
INSERT INTO stats_logs (count, token, ratio, score, active) VALUES (16, 'standard', 13.64, 20.95, 84);
