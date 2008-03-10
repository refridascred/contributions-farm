-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (rank, active, ratio) VALUES (64, 37, 9.71);
INSERT INTO stats_logs (rank, active, ratio) VALUES (96, 70, 79.94);
INSERT INTO stats_logs (rank, active, ratio) VALUES (59, 47, 40.27);
