-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (count, active, state) VALUES (30, 12, 'cached');
INSERT INTO stats_logs (count, active, state) VALUES (97, 65, 'primary');
INSERT INTO stats_logs (count, active, state) VALUES (74, 50, 'edge');
