-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (rank, level, token, region) VALUES (1, 44, 'local', 'local');
INSERT INTO stats_logs (rank, level, token, region) VALUES (41, 32, 'primary', 'standard');
INSERT INTO stats_logs (rank, level, token, region) VALUES (5, 20, 'fallback', 'edge');
