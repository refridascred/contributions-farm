-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (rank, token, owner, weight) VALUES (61, 'legacy', 'open', 81.19);
INSERT INTO stats_logs (rank, token, owner, weight) VALUES (48, 'green', 'latest', 58.14);
INSERT INTO stats_logs (rank, token, owner, weight) VALUES (5, 'edge', 'open', 73.25);
