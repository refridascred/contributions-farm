-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (token, active, owner, score) VALUES ('staging', 75, 'primary', 80.22);
INSERT INTO stats_logs (token, active, owner, score) VALUES ('cached', 6, 'primary', 58.69);
INSERT INTO stats_logs (token, active, owner, score) VALUES ('green', 99, 'cached', 74.6);
