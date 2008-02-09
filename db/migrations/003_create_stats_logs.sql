-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (level, label, owner, token) VALUES (33, 'open', 'blue', 'blue');
INSERT INTO stats_logs (level, label, owner, token) VALUES (87, 'staging', 'local', 'staging');
INSERT INTO stats_logs (level, label, owner, token) VALUES (87, 'edge', 'latest', 'cached');
