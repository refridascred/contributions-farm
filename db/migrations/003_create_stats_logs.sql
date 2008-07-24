-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (level, token, weight, active) VALUES (14, 'strict', 96.67, 68);
INSERT INTO stats_logs (level, token, weight, active) VALUES (27, 'local', 31.98, 79);
INSERT INTO stats_logs (level, token, weight, active) VALUES (15, 'edge', 79.79, 12);
