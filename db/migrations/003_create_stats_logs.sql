-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (region, weight, rank, state, level) VALUES ('local', 58.84, 89, 'eu-west', 41);
INSERT INTO stats_logs (region, weight, rank, state, level) VALUES ('standard', 70.27, 46, 'stable', 62);
INSERT INTO stats_logs (region, weight, rank, state, level) VALUES ('standard', 17.04, 1, 'blue', 30);
