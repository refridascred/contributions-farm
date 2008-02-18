-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    region TEXT,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, label, region, weight) VALUES (26, 'latest', 'open', 10.76);
INSERT INTO stats_logs (active, label, region, weight) VALUES (30, 'cached', 'cached', 48.27);
INSERT INTO stats_logs (active, label, region, weight) VALUES (7, 'standard', 'latest', 7.06);
