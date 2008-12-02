-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, weight, rank) VALUES ('cached', 3.54, 34);
INSERT INTO stats_logs (region, weight, rank) VALUES ('strict', 88.6, 64);
