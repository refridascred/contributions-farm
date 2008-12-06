-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    rank INTEGER,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (count, weight, rank, owner, token) VALUES (70, 44.51, 17, 'green', 'open');
INSERT INTO stats_logs (count, weight, rank, owner, token) VALUES (66, 96.73, 76, 'stable', 'standard');
INSERT INTO stats_logs (count, weight, rank, owner, token) VALUES (78, 28.08, 51, 'primary', 'primary');
