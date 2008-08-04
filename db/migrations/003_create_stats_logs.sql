-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (rank, token, label, level) VALUES (63, 'primary', 'blue', 6);
INSERT INTO stats_logs (rank, token, label, level) VALUES (58, 'local', 'strict', 88);
