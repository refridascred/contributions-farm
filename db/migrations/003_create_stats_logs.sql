-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (ratio, owner, state, score, active) VALUES (78.85, 'cached', 'staging', 27.38, 74);
INSERT INTO stats_logs (ratio, owner, state, score, active) VALUES (77.92, 'primary', 'primary', 65.85, 66);
