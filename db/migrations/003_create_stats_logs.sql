-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (owner, region, rank) VALUES ('cached', 'stable', 31);
INSERT INTO stats_logs (owner, region, rank) VALUES ('strict', 'local', 2);
