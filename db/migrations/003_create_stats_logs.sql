-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    token TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (weight, token, owner, active) VALUES (37.54, 'eu-west', 'edge', 1);
INSERT INTO stats_logs (weight, token, owner, active) VALUES (48.38, 'blue', 'local', 49);
INSERT INTO stats_logs (weight, token, owner, active) VALUES (6.08, 'standard', 'open', 44);
