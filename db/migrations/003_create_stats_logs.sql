-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (owner, state, active, rank) VALUES ('open', 'eu-west', 40, 46);
INSERT INTO stats_logs (owner, state, active, rank) VALUES ('standard', 'strict', 0, 11);
INSERT INTO stats_logs (owner, state, active, rank) VALUES ('stable', 'fallback', 77, 17);
