-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (state, rank, owner) VALUES ('green', 84, 'cached');
INSERT INTO stats_logs (state, rank, owner) VALUES ('open', 26, 'stable');
INSERT INTO stats_logs (state, rank, owner) VALUES ('stable', 50, 'edge');
