-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (state, active, score, label) VALUES ('staging', 72, 25.82, 'fallback');
INSERT INTO stats_logs (state, active, score, label) VALUES ('latest', 46, 26.68, 'cached');
INSERT INTO stats_logs (state, active, score, label) VALUES ('cached', 38, 28.74, 'stable');
