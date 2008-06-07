-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, region, active, state, ratio) VALUES (54.03, 'staging', 12, 'strict', 9.92);
INSERT INTO stats_logs (weight, region, active, state, ratio) VALUES (45.23, 'local', 55, 'latest', 76.68);
