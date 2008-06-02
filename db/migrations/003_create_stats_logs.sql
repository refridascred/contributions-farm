-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, level, state, active) VALUES (56, 88, 'legacy', 77);
INSERT INTO stats_logs (count, level, state, active) VALUES (4, 89, 'local', 33);
INSERT INTO stats_logs (count, level, state, active) VALUES (42, 73, 'latest', 59);
