-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (level, count, rank, state, region) VALUES (82, 80, 91, 'cached', 'standard');
INSERT INTO stats_logs (level, count, rank, state, region) VALUES (56, 57, 96, 'local', 'blue');
INSERT INTO stats_logs (level, count, rank, state, region) VALUES (44, 52, 93, 'local', 'edge');
