-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (label, owner, active, level) VALUES ('cached', 'primary', 2, 56);
INSERT INTO stats_logs (label, owner, active, level) VALUES ('legacy', 'legacy', 50, 70);
