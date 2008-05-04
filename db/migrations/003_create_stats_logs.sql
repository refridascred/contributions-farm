-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (state, count, score, ratio) VALUES ('stable', 6, 0.92, 10.64);
INSERT INTO stats_logs (state, count, score, ratio) VALUES ('staging', 69, 1.81, 6.23);
