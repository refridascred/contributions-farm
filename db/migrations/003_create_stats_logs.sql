-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (region, token, ratio) VALUES ('primary', 'eu-west', 35.87);
INSERT INTO stats_logs (region, token, ratio) VALUES ('edge', 'local', 46.03);
