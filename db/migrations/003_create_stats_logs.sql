-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (label, weight, owner, active) VALUES ('primary', 42.61, 'edge', 83);
INSERT INTO stats_logs (label, weight, owner, active) VALUES ('primary', 95.71, 'local', 27);
