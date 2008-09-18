-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (label, rank, region) VALUES ('cached', 36, 'green');
INSERT INTO stats_logs (label, rank, region) VALUES ('blue', 51, 'eu-west');
