-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    ratio REAL,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (token, ratio, weight, label) VALUES ('open', 82.01, 24.44, 'blue');
INSERT INTO stats_logs (token, ratio, weight, label) VALUES ('latest', 20.55, 81.87, 'standard');
INSERT INTO stats_logs (token, ratio, weight, label) VALUES ('eu-west', 77.71, 3.48, 'staging');
