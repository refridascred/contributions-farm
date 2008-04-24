-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (weight, owner, label) VALUES (32.63, 'blue', 'open');
INSERT INTO stats_logs (weight, owner, label) VALUES (26.41, 'primary', 'strict');
INSERT INTO stats_logs (weight, owner, label) VALUES (39.24, 'latest', 'stable');
