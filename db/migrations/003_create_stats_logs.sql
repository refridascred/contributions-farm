-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    rank INTEGER,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (level, token, rank, owner, label) VALUES (15, 'legacy', 3, 'green', 'green');
INSERT INTO stats_logs (level, token, rank, owner, label) VALUES (31, 'edge', 80, 'cached', 'strict');
INSERT INTO stats_logs (level, token, rank, owner, label) VALUES (55, 'eu-west', 38, 'stable', 'primary');
