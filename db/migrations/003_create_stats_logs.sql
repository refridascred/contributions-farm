-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, region, count, token, owner) VALUES ('open', 'open', 77, 'primary', 'local');
INSERT INTO stats_logs (label, region, count, token, owner) VALUES ('green', 'stable', 84, 'green', 'green');
