-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (owner, state, level, active, ratio) VALUES ('latest', 'fallback', 92, 47, 69.23);
INSERT INTO stats_logs (owner, state, level, active, ratio) VALUES ('standard', 'local', 71, 5, 72.64);
