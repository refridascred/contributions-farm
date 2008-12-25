-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (label, count, state, active, region) VALUES ('eu-west', 45, 'green', 40, 'edge');
INSERT INTO stats_logs (label, count, state, active, region) VALUES ('cached', 54, 'open', 92, 'edge');
INSERT INTO stats_logs (label, count, state, active, region) VALUES ('stable', 91, 'eu-west', 13, 'open');
