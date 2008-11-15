-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (state, active, level, score, ratio) VALUES ('cached', 15, 85, 25.22, 18.33);
INSERT INTO stats_logs (state, active, level, score, ratio) VALUES ('primary', 18, 74, 40.65, 18.59);
