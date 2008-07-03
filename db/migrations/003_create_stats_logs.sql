-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (weight, ratio, label, state) VALUES (19.91, 67.01, 'latest', 'cached');
INSERT INTO stats_logs (weight, ratio, label, state) VALUES (11.4, 32.41, 'primary', 'blue');
