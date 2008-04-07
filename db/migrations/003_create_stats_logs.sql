-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (owner, active, count, weight, label) VALUES ('eu-west', 64, 13, 73.24, 'green');
INSERT INTO stats_logs (owner, active, count, weight, label) VALUES ('green', 4, 54, 18.58, 'standard');
INSERT INTO stats_logs (owner, active, count, weight, label) VALUES ('cached', 92, 51, 50.0, 'primary');
