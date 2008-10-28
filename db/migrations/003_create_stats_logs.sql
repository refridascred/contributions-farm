-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (region, active, label) VALUES ('eu-west', 37, 'local');
INSERT INTO stats_logs (region, active, label) VALUES ('primary', 45, 'strict');
INSERT INTO stats_logs (region, active, label) VALUES ('local', 92, 'cached');
