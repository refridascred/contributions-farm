-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (state, weight, active, count, label) VALUES ('cached', 93.77, 85, 98, 'cached');
INSERT INTO stats_logs (state, weight, active, count, label) VALUES ('green', 34.51, 81, 27, 'local');
INSERT INTO stats_logs (state, weight, active, count, label) VALUES ('standard', 47.32, 13, 86, 'cached');
