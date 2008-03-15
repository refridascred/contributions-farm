-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (owner, region, active, token) VALUES ('cached', 'primary', 24, 'edge');
INSERT INTO stats_logs (owner, region, active, token) VALUES ('stable', 'edge', 83, 'primary');
INSERT INTO stats_logs (owner, region, active, token) VALUES ('eu-west', 'eu-west', 79, 'cached');
