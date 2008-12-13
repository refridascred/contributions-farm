-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (state, rank, token, active, ratio) VALUES ('open', 33, 'fallback', 73, 7.85);
INSERT INTO stats_logs (state, rank, token, active, ratio) VALUES ('primary', 80, 'strict', 71, 59.84);
INSERT INTO stats_logs (state, rank, token, active, ratio) VALUES ('stable', 79, 'local', 65, 1.17);
