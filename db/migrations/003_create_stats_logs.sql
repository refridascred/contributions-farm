-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    rank INTEGER,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (count, label, rank, owner, level) VALUES (56, 'standard', 98, 'strict', 1);
INSERT INTO stats_logs (count, label, rank, owner, level) VALUES (86, 'standard', 36, 'edge', 62);
