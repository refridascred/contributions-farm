-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, rank, state, weight, score) VALUES ('eu-west', 10, 'cached', 3.6, 97.67);
INSERT INTO stats_logs (owner, rank, state, weight, score) VALUES ('eu-west', 85, 'legacy', 68.59, 52.47);
INSERT INTO stats_logs (owner, rank, state, weight, score) VALUES ('cached', 96, 'cached', 97.23, 14.15);
