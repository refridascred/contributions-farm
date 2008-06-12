-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    region TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (owner, label, region, level, state) VALUES ('open', 'green', 'staging', 21, 'strict');
INSERT INTO stats_logs (owner, label, region, level, state) VALUES ('blue', 'blue', 'staging', 39, 'green');
