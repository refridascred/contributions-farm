-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (owner, level, rank, region) VALUES ('local', 2, 6, 'stable');
INSERT INTO stats_logs (owner, level, rank, region) VALUES ('strict', 98, 96, 'stable');
INSERT INTO stats_logs (owner, level, rank, region) VALUES ('primary', 0, 8, 'edge');
