-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (token, ratio, owner) VALUES ('edge', 89.48, 'open');
INSERT INTO stats_logs (token, ratio, owner) VALUES ('eu-west', 75.1, 'fallback');
INSERT INTO stats_logs (token, ratio, owner) VALUES ('primary', 18.89, 'eu-west');
