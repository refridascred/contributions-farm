-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (label, level, region) VALUES ('blue', 71, 'legacy');
INSERT INTO stats_logs (label, level, region) VALUES ('strict', 65, 'legacy');
INSERT INTO stats_logs (label, level, region) VALUES ('cached', 95, 'staging');
