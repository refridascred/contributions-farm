-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (state, rank, active, owner) VALUES ('green', 42, 54, 'local');
INSERT INTO stats_logs (state, rank, active, owner) VALUES ('eu-west', 86, 36, 'fallback');
INSERT INTO stats_logs (state, rank, active, owner) VALUES ('strict', 8, 60, 'green');
