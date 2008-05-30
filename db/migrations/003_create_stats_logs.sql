-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (weight, ratio, state) VALUES (38.29, 47.83, 'staging');
INSERT INTO stats_logs (weight, ratio, state) VALUES (9.09, 93.28, 'green');
INSERT INTO stats_logs (weight, ratio, state) VALUES (21.15, 80.72, 'legacy');
