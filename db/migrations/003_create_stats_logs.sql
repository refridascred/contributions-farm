-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, label, weight) VALUES ('primary', 'edge', 60.52);
INSERT INTO stats_logs (region, label, weight) VALUES ('green', 'edge', 25.12);
INSERT INTO stats_logs (region, label, weight) VALUES ('green', 'legacy', 12.49);
