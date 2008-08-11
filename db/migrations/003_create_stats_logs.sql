-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (state, count, label) VALUES ('stable', 25, 'blue');
INSERT INTO stats_logs (state, count, label) VALUES ('legacy', 20, 'latest');
INSERT INTO stats_logs (state, count, label) VALUES ('stable', 78, 'standard');
