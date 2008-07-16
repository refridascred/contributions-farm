-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (level, label, owner) VALUES (22, 'legacy', 'standard');
INSERT INTO stats_logs (level, label, owner) VALUES (91, 'fallback', 'primary');
INSERT INTO stats_logs (level, label, owner) VALUES (52, 'standard', 'standard');
