-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (token, ratio, rank, label) VALUES ('legacy', 13.49, 51, 'edge');
INSERT INTO stats_logs (token, ratio, rank, label) VALUES ('legacy', 68.53, 17, 'green');
INSERT INTO stats_logs (token, ratio, rank, label) VALUES ('blue', 10.93, 75, 'eu-west');
