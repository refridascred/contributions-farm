-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, active, owner) VALUES ('stable', 90, 'edge');
INSERT INTO stats_logs (region, active, owner) VALUES ('staging', 47, 'standard');
INSERT INTO stats_logs (region, active, owner) VALUES ('stable', 7, 'local');
