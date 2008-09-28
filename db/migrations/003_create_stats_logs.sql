-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (token, rank, region) VALUES ('strict', 85, 'staging');
INSERT INTO stats_logs (token, rank, region) VALUES ('latest', 14, 'standard');
