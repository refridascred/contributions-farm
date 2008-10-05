-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (level, rank, region, active, token) VALUES (17, 1, 'latest', 91, 'stable');
INSERT INTO stats_logs (level, rank, region, active, token) VALUES (14, 43, 'standard', 76, 'standard');
