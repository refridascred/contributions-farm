-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    owner TEXT NOT NULL,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (rank, level, owner, label, active) VALUES (96, 77, 'cached', 'stable', 33);
INSERT INTO stats_logs (rank, level, owner, label, active) VALUES (55, 1, 'open', 'fallback', 1);
INSERT INTO stats_logs (rank, level, owner, label, active) VALUES (44, 17, 'standard', 'eu-west', 12);
