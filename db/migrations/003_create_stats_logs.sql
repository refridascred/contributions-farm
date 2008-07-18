-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (count, rank, level, label) VALUES (68, 71, 21, 'green');
INSERT INTO stats_logs (count, rank, level, label) VALUES (30, 76, 70, 'open');
INSERT INTO stats_logs (count, rank, level, label) VALUES (78, 74, 41, 'standard');
