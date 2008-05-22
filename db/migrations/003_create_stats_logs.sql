-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (weight, ratio, active, state) VALUES (3.41, 51.94, 89, 'fallback');
