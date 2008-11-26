-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (state, active, ratio, count) VALUES ('blue', 9, 15.48, 12);
INSERT INTO stats_logs (state, active, ratio, count) VALUES ('cached', 98, 75.37, 41);
INSERT INTO stats_logs (state, active, ratio, count) VALUES ('local', 8, 98.04, 92);
