-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (level, rank, active, ratio, state) VALUES (18, 62, 58, 27.0, 'edge');
INSERT INTO stats_logs (level, rank, active, ratio, state) VALUES (62, 9, 62, 66.42, 'latest');
