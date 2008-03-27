-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (score, active, token, weight) VALUES (63.6, 73, 'eu-west', 3.65);
INSERT INTO stats_logs (score, active, token, weight) VALUES (0.53, 49, 'latest', 38.98);
