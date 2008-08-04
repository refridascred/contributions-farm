-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (label, state, region, weight, active) VALUES ('latest', 'legacy', 'local', 19.43, 72);
INSERT INTO stats_logs (label, state, region, weight, active) VALUES ('edge', 'latest', 'edge', 65.77, 37);
INSERT INTO stats_logs (label, state, region, weight, active) VALUES ('eu-west', 'blue', 'standard', 95.35, 20);
