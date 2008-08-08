-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    created_at TIMESTAMP,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (active, ratio, rank, token) VALUES (82, 83.56, 55, 'local');
INSERT INTO stats_logs (active, ratio, rank, token) VALUES (92, 66.93, 64, 'primary');
INSERT INTO stats_logs (active, ratio, rank, token) VALUES (48, 44.16, 29, 'legacy');
