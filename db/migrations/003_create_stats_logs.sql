-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (rank, label, level, token) VALUES (25, 'local', 83, 'eu-west');
INSERT INTO stats_logs (rank, label, level, token) VALUES (13, 'fallback', 74, 'cached');
