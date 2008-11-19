-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, weight, region) VALUES ('edge', 67.92, 'standard');
INSERT INTO stats_logs (label, weight, region) VALUES ('blue', 76.55, 'fallback');
