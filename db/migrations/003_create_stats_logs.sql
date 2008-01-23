-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (token, weight) VALUES ('local', 7.13);
INSERT INTO stats_logs (token, weight) VALUES ('green', 35.69);
