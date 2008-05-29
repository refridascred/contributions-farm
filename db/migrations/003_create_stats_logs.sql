-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (ratio, owner, rank) VALUES (80.37, 'primary', 35);
INSERT INTO stats_logs (ratio, owner, rank) VALUES (66.32, 'latest', 32);
INSERT INTO stats_logs (ratio, owner, rank) VALUES (80.32, 'stable', 98);
