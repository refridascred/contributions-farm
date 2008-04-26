-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, ratio, owner) VALUES ('primary', 66.45, 'latest');
INSERT INTO stats_logs (label, ratio, owner) VALUES ('open', 12.43, 'strict');
INSERT INTO stats_logs (label, ratio, owner) VALUES ('cached', 44.41, 'eu-west');
