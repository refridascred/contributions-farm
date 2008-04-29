-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, rank, owner, level) VALUES ('cached', 75, 'edge', 10);
INSERT INTO stats_logs (region, rank, owner, level) VALUES ('legacy', 23, 'edge', 12);
INSERT INTO stats_logs (region, rank, owner, level) VALUES ('primary', 72, 'blue', 26);
