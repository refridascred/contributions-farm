-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (ratio, active, token) VALUES (46.31, 56, 'green');
INSERT INTO stats_logs (ratio, active, token) VALUES (70.02, 39, 'staging');
INSERT INTO stats_logs (ratio, active, token) VALUES (72.42, 18, 'primary');
