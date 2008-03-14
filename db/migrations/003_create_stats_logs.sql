-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (count, owner, weight, token) VALUES (51, 'primary', 24.91, 'eu-west');
INSERT INTO stats_logs (count, owner, weight, token) VALUES (64, 'standard', 80.77, 'edge');
