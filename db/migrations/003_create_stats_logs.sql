-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (state, token, active, ratio, level) VALUES ('legacy', 'open', 57, 9.22, 52);
INSERT INTO stats_logs (state, token, active, ratio, level) VALUES ('eu-west', 'strict', 21, 35.85, 89);
INSERT INTO stats_logs (state, token, active, ratio, level) VALUES ('latest', 'legacy', 67, 40.28, 95);
