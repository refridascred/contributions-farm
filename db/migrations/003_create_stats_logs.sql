-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, level, region, state, count) VALUES (20.61, 54, 'eu-west', 'cached', 58);
INSERT INTO stats_logs (weight, level, region, state, count) VALUES (11.85, 46, 'edge', 'local', 81);
INSERT INTO stats_logs (weight, level, region, state, count) VALUES (92.73, 12, 'latest', 'primary', 60);
