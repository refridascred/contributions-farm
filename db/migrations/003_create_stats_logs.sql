-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (region, weight, state, level, active) VALUES ('strict', 50.84, 'latest', 90, 94);
INSERT INTO stats_logs (region, weight, state, level, active) VALUES ('standard', 85.65, 'open', 18, 28);
