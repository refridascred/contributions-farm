-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (ratio, label, owner, active) VALUES (79.75, 'fallback', 'primary', 6);
INSERT INTO stats_logs (ratio, label, owner, active) VALUES (45.82, 'edge', 'legacy', 16);
INSERT INTO stats_logs (ratio, label, owner, active) VALUES (53.01, 'primary', 'blue', 3);
