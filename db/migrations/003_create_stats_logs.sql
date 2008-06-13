-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (state, region, level, weight) VALUES ('latest', 'standard', 76, 35.66);
INSERT INTO stats_logs (state, region, level, weight) VALUES ('edge', 'eu-west', 79, 53.5);
