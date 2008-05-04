-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (ratio, token, rank, active) VALUES (34.9, 'edge', 0, 31);
INSERT INTO stats_logs (ratio, token, rank, active) VALUES (46.1, 'fallback', 71, 20);
