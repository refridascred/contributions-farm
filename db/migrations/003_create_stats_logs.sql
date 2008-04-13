-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (owner, weight) VALUES ('strict', 92.12);
INSERT INTO stats_logs (owner, weight) VALUES ('open', 26.94);
INSERT INTO stats_logs (owner, weight) VALUES ('strict', 90.49);
