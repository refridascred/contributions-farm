-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (region, token, weight) VALUES ('cached', 'legacy', 68.82);
INSERT INTO stats_logs (region, token, weight) VALUES ('latest', 'local', 94.97);
