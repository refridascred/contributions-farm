-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, rank, token) VALUES (56, 7, 'open');
INSERT INTO stats_logs (level, rank, token) VALUES (42, 12, 'cached');
INSERT INTO stats_logs (level, rank, token) VALUES (67, 33, 'cached');
