-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    rank INTEGER,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (level, label, rank, token) VALUES (57, 'fallback', 84, 'cached');
INSERT INTO stats_logs (level, label, rank, token) VALUES (42, 'latest', 22, 'latest');
INSERT INTO stats_logs (level, label, rank, token) VALUES (74, 'strict', 30, 'green');
