-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (label, token, weight) VALUES ('green', 'eu-west', 39.56);
INSERT INTO stats_logs (label, token, weight) VALUES ('strict', 'primary', 0.55);
