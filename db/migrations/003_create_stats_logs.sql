-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (state, weight, level) VALUES ('blue', 2.65, 70);
INSERT INTO stats_logs (state, weight, level) VALUES ('standard', 38.93, 35);
INSERT INTO stats_logs (state, weight, level) VALUES ('eu-west', 32.11, 18);
