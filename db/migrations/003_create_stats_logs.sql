-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    owner TEXT NOT NULL,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (level, rank, owner, weight, active) VALUES (7, 52, 'edge', 38.08, 43);
INSERT INTO stats_logs (level, rank, owner, weight, active) VALUES (49, 72, 'green', 50.69, 23);
