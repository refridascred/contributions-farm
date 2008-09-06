-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (state, count, ratio) VALUES ('standard', 94, 86.67);
INSERT INTO stats_logs (state, count, ratio) VALUES ('stable', 24, 77.24);
INSERT INTO stats_logs (state, count, ratio) VALUES ('standard', 67, 86.94);
