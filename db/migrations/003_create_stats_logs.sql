-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, active, weight, owner, rank) VALUES ('local', 5, 92.96, 'open', 16);
INSERT INTO stats_logs (state, active, weight, owner, rank) VALUES ('primary', 70, 54.37, 'local', 59);
INSERT INTO stats_logs (state, active, weight, owner, rank) VALUES ('cached', 99, 69.76, 'legacy', 71);
