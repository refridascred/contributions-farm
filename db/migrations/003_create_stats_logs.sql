-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (token, weight) VALUES ('blue', 72.84);
INSERT INTO stats_logs (token, weight) VALUES ('standard', 96.11);
INSERT INTO stats_logs (token, weight) VALUES ('green', 24.69);
