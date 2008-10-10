-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (label, level, state, score) VALUES ('legacy', 78, 'primary', 80.62);
INSERT INTO stats_logs (label, level, state, score) VALUES ('stable', 28, 'strict', 78.64);
INSERT INTO stats_logs (label, level, state, score) VALUES ('eu-west', 60, 'eu-west', 11.11);
