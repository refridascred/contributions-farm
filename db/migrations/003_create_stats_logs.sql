-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, weight, token) VALUES ('latest', 56.76, 'edge');
INSERT INTO stats_logs (label, weight, token) VALUES ('eu-west', 12.35, 'legacy');
INSERT INTO stats_logs (label, weight, token) VALUES ('standard', 81.63, 'cached');
