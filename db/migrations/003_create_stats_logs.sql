-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (label, token, weight) VALUES ('latest', 'standard', 6.98);
INSERT INTO stats_logs (label, token, weight) VALUES ('blue', 'fallback', 46.13);
INSERT INTO stats_logs (label, token, weight) VALUES ('fallback', 'blue', 28.34);
