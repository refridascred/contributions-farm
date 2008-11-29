-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, score, state, level) VALUES ('latest', 75.44, 'standard', 13);
INSERT INTO stats_logs (owner, score, state, level) VALUES ('eu-west', 51.6, 'edge', 90);
INSERT INTO stats_logs (owner, score, state, level) VALUES ('blue', 12.34, 'green', 90);
