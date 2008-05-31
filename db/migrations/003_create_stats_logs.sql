-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    rank INTEGER,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, region, rank, label, count) VALUES ('cached', 'cached', 85, 'edge', 16);
INSERT INTO stats_logs (state, region, rank, label, count) VALUES ('cached', 'staging', 40, 'latest', 60);
