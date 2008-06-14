-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (rank, label, ratio, token) VALUES (36, 'staging', 84.19, 'local');
INSERT INTO stats_logs (rank, label, ratio, token) VALUES (71, 'cached', 22.77, 'primary');
