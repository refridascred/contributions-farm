-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (label, rank, active, owner, token) VALUES ('blue', 87, 20, 'edge', 'primary');
INSERT INTO stats_logs (label, rank, active, owner, token) VALUES ('green', 43, 98, 'stable', 'edge');
