-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (weight, token, ratio) VALUES (74.05, 'primary', 17.99);
INSERT INTO stats_logs (weight, token, ratio) VALUES (21.9, 'local', 81.91);
