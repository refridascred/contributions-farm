-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (ratio, token, active, weight, score) VALUES (89.14, 'primary', 60, 32.19, 5.56);
INSERT INTO stats_logs (ratio, token, active, weight, score) VALUES (38.45, 'local', 4, 60.19, 27.57);
