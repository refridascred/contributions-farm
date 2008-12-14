-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (level, token, rank) VALUES (32, 'primary', 75);
INSERT INTO stats_logs (level, token, rank) VALUES (49, 'primary', 24);
INSERT INTO stats_logs (level, token, rank) VALUES (95, 'primary', 42);
