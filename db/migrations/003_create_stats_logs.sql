-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, owner, level) VALUES (96.99, 'eu-west', 36);
INSERT INTO stats_logs (weight, owner, level) VALUES (43.55, 'standard', 73);
