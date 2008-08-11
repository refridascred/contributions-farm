-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (region, weight, state) VALUES ('primary', 35.72, 'open');
INSERT INTO stats_logs (region, weight, state) VALUES ('open', 68.67, 'fallback');
