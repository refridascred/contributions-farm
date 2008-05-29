-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (token, weight, rank) VALUES ('strict', 97.08, 81);
INSERT INTO stats_logs (token, weight, rank) VALUES ('open', 38.23, 2);
