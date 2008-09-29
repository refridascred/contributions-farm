-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (rank, weight, label) VALUES (24, 63.78, 'standard');
INSERT INTO stats_logs (rank, weight, label) VALUES (57, 76.4, 'blue');
INSERT INTO stats_logs (rank, weight, label) VALUES (22, 84.66, 'edge');
