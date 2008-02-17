-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (owner, rank, region) VALUES ('open', 69, 'primary');
INSERT INTO stats_logs (owner, rank, region) VALUES ('stable', 6, 'latest');
INSERT INTO stats_logs (owner, rank, region) VALUES ('stable', 16, 'stable');
