-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (count, owner, state, rank) VALUES (29, 'fallback', 'strict', 67);
INSERT INTO stats_logs (count, owner, state, rank) VALUES (38, 'strict', 'standard', 40);
INSERT INTO stats_logs (count, owner, state, rank) VALUES (72, 'strict', 'blue', 70);
