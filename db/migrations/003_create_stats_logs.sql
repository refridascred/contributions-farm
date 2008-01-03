-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (ratio, region, label, active) VALUES (57.71, 'cached', 'legacy', 37);
INSERT INTO stats_logs (ratio, region, label, active) VALUES (69.89, 'standard', 'open', 87);
INSERT INTO stats_logs (ratio, region, label, active) VALUES (53.2, 'fallback', 'fallback', 32);
