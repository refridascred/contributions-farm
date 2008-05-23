-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (rank, label, count, token) VALUES (18, 'latest', 24, 'local');
INSERT INTO stats_logs (rank, label, count, token) VALUES (50, 'staging', 77, 'legacy');
INSERT INTO stats_logs (rank, label, count, token) VALUES (24, 'strict', 38, 'local');
