-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (rank, level, label, region) VALUES (15, 51, 'legacy', 'local');
INSERT INTO stats_logs (rank, level, label, region) VALUES (46, 7, 'cached', 'green');
INSERT INTO stats_logs (rank, level, label, region) VALUES (92, 53, 'latest', 'cached');
