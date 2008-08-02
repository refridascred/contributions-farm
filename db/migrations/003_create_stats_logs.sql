-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (rank, token, label) VALUES (91, 'green', 'standard');
INSERT INTO stats_logs (rank, token, label) VALUES (91, 'stable', 'strict');
INSERT INTO stats_logs (rank, token, label) VALUES (91, 'green', 'open');
