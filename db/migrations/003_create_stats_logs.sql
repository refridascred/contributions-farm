-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (token, label, weight) VALUES ('stable', 'eu-west', 27.2);
INSERT INTO stats_logs (token, label, weight) VALUES ('stable', 'eu-west', 27.84);
