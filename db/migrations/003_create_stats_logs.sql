-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (state, active, level, token) VALUES ('latest', 54, 36, 'green');
INSERT INTO stats_logs (state, active, level, token) VALUES ('primary', 16, 41, 'strict');
INSERT INTO stats_logs (state, active, level, token) VALUES ('primary', 8, 45, 'staging');
