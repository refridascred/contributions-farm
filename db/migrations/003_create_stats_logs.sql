-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (state, level, rank, count, owner) VALUES ('standard', 50, 42, 77, 'fallback');
INSERT INTO stats_logs (state, level, rank, count, owner) VALUES ('stable', 40, 0, 29, 'eu-west');
