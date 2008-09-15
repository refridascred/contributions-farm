-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (weight, score, active) VALUES (36.13, 73.44, 12);
INSERT INTO stats_logs (weight, score, active) VALUES (63.08, 49.46, 38);
INSERT INTO stats_logs (weight, score, active) VALUES (46.6, 27.21, 25);
