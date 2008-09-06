-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, token, rank, label) VALUES (26, 'stable', 2, 'edge');
INSERT INTO stats_logs (count, token, rank, label) VALUES (45, 'primary', 51, 'staging');
INSERT INTO stats_logs (count, token, rank, label) VALUES (35, 'local', 42, 'latest');
