-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (active, ratio, score, owner, state) VALUES (62, 30.09, 45.85, 'open', 'local');
INSERT INTO stats_logs (active, ratio, score, owner, state) VALUES (97, 10.51, 21.43, 'eu-west', 'blue');
INSERT INTO stats_logs (active, ratio, score, owner, state) VALUES (90, 80.98, 75.91, 'strict', 'legacy');
