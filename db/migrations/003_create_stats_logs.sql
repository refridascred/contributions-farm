-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (rank, owner, level) VALUES (93, 'stable', 91);
INSERT INTO stats_logs (rank, owner, level) VALUES (61, 'blue', 27);
INSERT INTO stats_logs (rank, owner, level) VALUES (25, 'latest', 23);
