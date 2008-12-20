-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, active, region, score, count) VALUES ('staging', 21, 'green', 6.82, 26);
INSERT INTO stats_logs (state, active, region, score, count) VALUES ('eu-west', 48, 'stable', 88.81, 29);
INSERT INTO stats_logs (state, active, region, score, count) VALUES ('stable', 30, 'eu-west', 80.28, 35);
