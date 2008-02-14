-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    owner TEXT NOT NULL,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (region, weight, owner, label, token) VALUES ('cached', 59.94, 'strict', 'green', 'blue');
INSERT INTO stats_logs (region, weight, owner, label, token) VALUES ('cached', 89.14, 'strict', 'legacy', 'legacy');
INSERT INTO stats_logs (region, weight, owner, label, token) VALUES ('standard', 11.45, 'stable', 'eu-west', 'stable');
