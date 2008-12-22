-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, count, owner) VALUES ('eu-west', 97, 'local');
INSERT INTO stats_logs (state, count, owner) VALUES ('legacy', 60, 'cached');
INSERT INTO stats_logs (state, count, owner) VALUES ('cached', 74, 'blue');
