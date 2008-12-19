-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, weight, state, count, score) VALUES (63, 31.56, 'latest', 48, 44.27);
INSERT INTO stats_logs (active, weight, state, count, score) VALUES (4, 72.69, 'staging', 34, 50.06);
INSERT INTO stats_logs (active, weight, state, count, score) VALUES (45, 0.12, 'blue', 64, 64.25);
