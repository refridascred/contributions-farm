-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, active, weight) VALUES ('strict', 15, 39.64);
INSERT INTO stats_logs (region, active, weight) VALUES ('standard', 13, 84.96);
INSERT INTO stats_logs (region, active, weight) VALUES ('cached', 10, 22.39);
