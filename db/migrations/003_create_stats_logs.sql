-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (token, owner, count, weight, label) VALUES ('edge', 'latest', 77, 94.58, 'primary');
INSERT INTO stats_logs (token, owner, count, weight, label) VALUES ('open', 'blue', 50, 44.57, 'staging');
INSERT INTO stats_logs (token, owner, count, weight, label) VALUES ('local', 'standard', 47, 58.13, 'fallback');
