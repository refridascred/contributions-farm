-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, level, owner) VALUES ('standard', 29, 'blue');
INSERT INTO stats_logs (label, level, owner) VALUES ('legacy', 42, 'strict');
INSERT INTO stats_logs (label, level, owner) VALUES ('local', 95, 'blue');
