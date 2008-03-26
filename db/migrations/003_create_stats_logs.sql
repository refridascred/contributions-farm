-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (label, token, rank, level) VALUES ('stable', 'fallback', 85, 6);
INSERT INTO stats_logs (label, token, rank, level) VALUES ('primary', 'open', 74, 44);
INSERT INTO stats_logs (label, token, rank, level) VALUES ('edge', 'local', 3, 56);
