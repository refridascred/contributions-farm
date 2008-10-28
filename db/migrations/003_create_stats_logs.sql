-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    weight REAL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (rank, ratio, weight, token, active) VALUES (48, 45.23, 75.33, 'fallback', 62);
INSERT INTO stats_logs (rank, ratio, weight, token, active) VALUES (33, 24.02, 8.38, 'local', 79);
