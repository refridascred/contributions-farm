-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (token, ratio, owner) VALUES ('standard', 9.14, 'staging');
INSERT INTO stats_logs (token, ratio, owner) VALUES ('eu-west', 64.22, 'staging');
INSERT INTO stats_logs (token, ratio, owner) VALUES ('edge', 18.28, 'cached');
