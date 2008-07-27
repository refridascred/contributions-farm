-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (owner, active, rank, count) VALUES ('legacy', 7, 71, 33);
INSERT INTO stats_logs (owner, active, rank, count) VALUES ('open', 38, 94, 15);
INSERT INTO stats_logs (owner, active, rank, count) VALUES ('strict', 53, 21, 43);
