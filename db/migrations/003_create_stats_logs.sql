-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (rank, level, owner, ratio) VALUES (99, 53, 'cached', 34.13);
INSERT INTO stats_logs (rank, level, owner, ratio) VALUES (38, 89, 'local', 40.97);
