-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (owner, active, region, label) VALUES ('cached', 0, 'edge', 'stable');
INSERT INTO stats_logs (owner, active, region, label) VALUES ('latest', 72, 'eu-west', 'local');
