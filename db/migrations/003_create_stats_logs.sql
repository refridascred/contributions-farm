-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (token, weight, owner, label) VALUES ('stable', 64.92, 'primary', 'open');
INSERT INTO stats_logs (token, weight, owner, label) VALUES ('blue', 29.98, 'legacy', 'legacy');
