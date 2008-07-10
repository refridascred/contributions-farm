-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (score, active, owner) VALUES (11.79, 55, 'fallback');
INSERT INTO stats_logs (score, active, owner) VALUES (73.76, 54, 'green');
INSERT INTO stats_logs (score, active, owner) VALUES (90.73, 51, 'green');
