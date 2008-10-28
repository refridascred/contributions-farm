-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    label TEXT,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (token, label, ratio, owner) VALUES ('eu-west', 'primary', 51.71, 'primary');
INSERT INTO stats_logs (token, label, ratio, owner) VALUES ('standard', 'cached', 3.26, 'primary');
