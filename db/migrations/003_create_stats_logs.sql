-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (label, level, owner, state) VALUES ('eu-west', 30, 'latest', 'primary');
INSERT INTO stats_logs (label, level, owner, state) VALUES ('legacy', 64, 'edge', 'standard');
INSERT INTO stats_logs (label, level, owner, state) VALUES ('blue', 85, 'latest', 'primary');
