-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, rank) VALUES ('strict', 42);
INSERT INTO stats_logs (region, rank) VALUES ('cached', 19);
INSERT INTO stats_logs (region, rank) VALUES ('strict', 97);
