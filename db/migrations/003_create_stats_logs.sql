-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, state, region) VALUES (46, 'latest', 'blue');
INSERT INTO stats_logs (count, state, region) VALUES (36, 'cached', 'blue');
INSERT INTO stats_logs (count, state, region) VALUES (6, 'legacy', 'staging');
