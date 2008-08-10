-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, active, region, weight) VALUES ('local', 93, 'fallback', 20.71);
INSERT INTO stats_logs (label, active, region, weight) VALUES ('strict', 75, 'blue', 4.81);
INSERT INTO stats_logs (label, active, region, weight) VALUES ('edge', 20, 'legacy', 3.09);
