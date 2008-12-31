-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (ratio, active, rank, owner, token) VALUES (56.83, 82, 44, 'strict', 'eu-west');
INSERT INTO stats_logs (ratio, active, rank, owner, token) VALUES (63.0, 88, 9, 'cached', 'latest');
INSERT INTO stats_logs (ratio, active, rank, owner, token) VALUES (83.71, 34, 78, 'blue', 'open');
