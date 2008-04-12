-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (rank, token, ratio) VALUES (50, 'local', 62.07);
INSERT INTO stats_logs (rank, token, ratio) VALUES (4, 'edge', 64.59);
