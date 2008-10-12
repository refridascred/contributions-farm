-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (owner, score, state) VALUES ('eu-west', 63.65, 'edge');
INSERT INTO stats_logs (owner, score, state) VALUES ('stable', 86.44, 'standard');
INSERT INTO stats_logs (owner, score, state) VALUES ('open', 33.25, 'primary');
