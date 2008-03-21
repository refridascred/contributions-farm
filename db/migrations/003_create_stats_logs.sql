-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, level, token, active) VALUES ('primary', 79, 'strict', 22);
