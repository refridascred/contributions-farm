-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (token, region, weight) VALUES ('cached', 'legacy', 5.17);
INSERT INTO stats_logs (token, region, weight) VALUES ('edge', 'open', 33.17);
INSERT INTO stats_logs (token, region, weight) VALUES ('strict', 'standard', 7.73);
