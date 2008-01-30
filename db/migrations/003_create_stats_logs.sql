-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (count, label, rank, state, level) VALUES (84, 'local', 1, 'strict', 31);
INSERT INTO stats_logs (count, label, rank, state, level) VALUES (33, 'local', 80, 'stable', 28);
INSERT INTO stats_logs (count, label, rank, state, level) VALUES (76, 'eu-west', 22, 'local', 81);
