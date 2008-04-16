-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (region, ratio, state, rank, level) VALUES ('primary', 70.42, 'latest', 29, 88);
INSERT INTO stats_logs (region, ratio, state, rank, level) VALUES ('blue', 34.57, 'edge', 11, 98);
INSERT INTO stats_logs (region, ratio, state, rank, level) VALUES ('open', 85.73, 'cached', 2, 26);
