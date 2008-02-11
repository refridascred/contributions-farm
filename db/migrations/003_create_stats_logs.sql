-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (level, owner, label) VALUES (13, 'local', 'open');
INSERT INTO stats_logs (level, owner, label) VALUES (11, 'standard', 'legacy');
INSERT INTO stats_logs (level, owner, label) VALUES (65, 'legacy', 'cached');
