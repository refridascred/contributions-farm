-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, score, active, token) VALUES ('green', 69.61, 4, 'edge');
INSERT INTO stats_logs (owner, score, active, token) VALUES ('primary', 93.98, 68, 'blue');
INSERT INTO stats_logs (owner, score, active, token) VALUES ('green', 24.19, 46, 'staging');
