-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (state, level, count, rank) VALUES ('edge', 69, 6, 69);
