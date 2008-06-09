-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (rank, ratio, token, state) VALUES (31, 30.69, 'stable', 'primary');
INSERT INTO stats_logs (rank, ratio, token, state) VALUES (94, 2.52, 'latest', 'standard');
INSERT INTO stats_logs (rank, ratio, token, state) VALUES (11, 58.1, 'blue', 'eu-west');
