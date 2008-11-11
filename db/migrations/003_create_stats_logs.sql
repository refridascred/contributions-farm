-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (token, level, label, state, score) VALUES ('staging', 67, 'open', 'primary', 79.62);
INSERT INTO stats_logs (token, level, label, state, score) VALUES ('staging', 92, 'latest', 'latest', 74.07);
