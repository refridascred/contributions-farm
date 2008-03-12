-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (ratio, level, active, owner) VALUES (42.4, 39, 71, 'green');
INSERT INTO stats_logs (ratio, level, active, owner) VALUES (27.41, 48, 81, 'staging');
INSERT INTO stats_logs (ratio, level, active, owner) VALUES (64.65, 64, 42, 'standard');
