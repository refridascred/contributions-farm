-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, count, region, label) VALUES ('blue', 88, 'eu-west', 'eu-west');
INSERT INTO stats_logs (state, count, region, label) VALUES ('green', 3, 'local', 'cached');
INSERT INTO stats_logs (state, count, region, label) VALUES ('blue', 45, 'legacy', 'eu-west');
