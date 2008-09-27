-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, rank, state, owner, ratio) VALUES ('eu-west', 79, 'primary', 'stable', 45.84);
INSERT INTO stats_logs (token, rank, state, owner, ratio) VALUES ('primary', 59, 'green', 'standard', 24.61);
