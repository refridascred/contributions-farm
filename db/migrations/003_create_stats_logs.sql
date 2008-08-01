-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (weight, active, ratio, state) VALUES (52.32, 7, 75.36, 'staging');
INSERT INTO stats_logs (weight, active, ratio, state) VALUES (95.84, 44, 58.35, 'standard');
INSERT INTO stats_logs (weight, active, ratio, state) VALUES (83.13, 77, 35.95, 'legacy');
