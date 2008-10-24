-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (active, state, region, count, ratio) VALUES (98, 'latest', 'standard', 16, 83.07);
INSERT INTO stats_logs (active, state, region, count, ratio) VALUES (79, 'staging', 'latest', 17, 16.98);
INSERT INTO stats_logs (active, state, region, count, ratio) VALUES (83, 'local', 'open', 82, 80.97);
