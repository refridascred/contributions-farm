-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (rank, ratio, level, state) VALUES (34, 10.06, 12, 'edge');
INSERT INTO stats_logs (rank, ratio, level, state) VALUES (22, 76.88, 83, 'latest');
INSERT INTO stats_logs (rank, ratio, level, state) VALUES (21, 58.47, 62, 'standard');
