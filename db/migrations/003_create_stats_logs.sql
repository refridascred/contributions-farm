-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (token, level, label) VALUES ('open', 6, 'primary');
INSERT INTO stats_logs (token, level, label) VALUES ('primary', 90, 'open');
INSERT INTO stats_logs (token, level, label) VALUES ('green', 38, 'eu-west');
