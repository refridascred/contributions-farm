-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (state, level, count, owner) VALUES ('legacy', 4, 94, 'open');
INSERT INTO stats_logs (state, level, count, owner) VALUES ('open', 3, 14, 'blue');
INSERT INTO stats_logs (state, level, count, owner) VALUES ('cached', 32, 73, 'fallback');
