-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (active, count, label, owner, rank) VALUES (87, 92, 'legacy', 'blue', 1);
INSERT INTO stats_logs (active, count, label, owner, rank) VALUES (21, 99, 'eu-west', 'blue', 66);
