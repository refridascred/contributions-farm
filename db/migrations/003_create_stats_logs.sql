-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (rank, ratio, active, owner, level) VALUES (77, 87.49, 51, 'green', 74);
INSERT INTO stats_logs (rank, ratio, active, owner, level) VALUES (83, 95.87, 25, 'fallback', 78);
INSERT INTO stats_logs (rank, ratio, active, owner, level) VALUES (28, 58.59, 77, 'staging', 39);
