-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (region, label, count, state) VALUES ('stable', 'staging', 21, 'primary');
INSERT INTO stats_logs (region, label, count, state) VALUES ('legacy', 'staging', 66, 'edge');
INSERT INTO stats_logs (region, label, count, state) VALUES ('fallback', 'local', 44, 'open');
