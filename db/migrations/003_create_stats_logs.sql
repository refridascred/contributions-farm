-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (active, rank, owner, weight) VALUES (32, 80, 'open', 8.97);
INSERT INTO stats_logs (active, rank, owner, weight) VALUES (27, 1, 'eu-west', 49.45);
