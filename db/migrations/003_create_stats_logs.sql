-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (weight, ratio, token, count) VALUES (38.91, 81.81, 'primary', 85);
INSERT INTO stats_logs (weight, ratio, token, count) VALUES (11.64, 81.43, 'strict', 20);
INSERT INTO stats_logs (weight, ratio, token, count) VALUES (86.1, 33.39, 'stable', 80);
