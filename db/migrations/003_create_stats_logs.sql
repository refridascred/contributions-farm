-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (region, ratio, active, state) VALUES ('edge', 14.09, 50, 'staging');
INSERT INTO stats_logs (region, ratio, active, state) VALUES ('primary', 47.76, 31, 'eu-west');
INSERT INTO stats_logs (region, ratio, active, state) VALUES ('strict', 34.06, 13, 'blue');
