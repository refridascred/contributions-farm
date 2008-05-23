-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, count, owner, score, state) VALUES ('standard', 75, 'stable', 78.4, 'legacy');
INSERT INTO stats_logs (label, count, owner, score, state) VALUES ('open', 35, 'green', 6.62, 'blue');
INSERT INTO stats_logs (label, count, owner, score, state) VALUES ('eu-west', 33, 'open', 85.53, 'latest');
