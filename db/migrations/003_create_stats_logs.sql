-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (rank, ratio, state, count) VALUES (43, 47.77, 'latest', 35);
INSERT INTO stats_logs (rank, ratio, state, count) VALUES (58, 40.45, 'staging', 20);
INSERT INTO stats_logs (rank, ratio, state, count) VALUES (35, 4.52, 'local', 76);
