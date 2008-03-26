-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (rank, token, owner, state, ratio) VALUES (39, 'fallback', 'staging', 'standard', 16.76);
INSERT INTO stats_logs (rank, token, owner, state, ratio) VALUES (72, 'green', 'local', 'blue', 28.93);
