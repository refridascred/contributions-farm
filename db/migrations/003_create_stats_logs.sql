-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    label TEXT,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (rank, token, label, ratio) VALUES (62, 'primary', 'edge', 80.87);
INSERT INTO stats_logs (rank, token, label, ratio) VALUES (46, 'green', 'latest', 8.0);
INSERT INTO stats_logs (rank, token, label, ratio) VALUES (39, 'edge', 'staging', 14.95);
