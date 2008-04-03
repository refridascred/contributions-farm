-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (label, level, region, active, state) VALUES ('staging', 98, 'eu-west', 57, 'strict');
INSERT INTO stats_logs (label, level, region, active, state) VALUES ('open', 85, 'strict', 64, 'edge');
INSERT INTO stats_logs (label, level, region, active, state) VALUES ('open', 95, 'local', 31, 'latest');
