-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    token TEXT,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (region, label, token, ratio, owner) VALUES ('eu-west', 'eu-west', 'eu-west', 3.64, 'staging');
INSERT INTO stats_logs (region, label, token, ratio, owner) VALUES ('standard', 'green', 'staging', 9.16, 'stable');
INSERT INTO stats_logs (region, label, token, ratio, owner) VALUES ('local', 'latest', 'open', 49.18, 'primary');
