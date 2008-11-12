-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, count, region) VALUES ('stable', 64, 'cached');
INSERT INTO stats_logs (state, count, region) VALUES ('local', 42, 'open');
INSERT INTO stats_logs (state, count, region) VALUES ('stable', 17, 'fallback');
