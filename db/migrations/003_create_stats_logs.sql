-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (owner, ratio, weight) VALUES ('staging', 79.16, 62.22);
INSERT INTO stats_logs (owner, ratio, weight) VALUES ('strict', 37.15, 78.55);
INSERT INTO stats_logs (owner, ratio, weight) VALUES ('cached', 45.82, 1.4);
