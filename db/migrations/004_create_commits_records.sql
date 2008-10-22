-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (owner, active, state, score, rank) VALUES ('cached', 58, 'eu-west', 91.18, 0);
INSERT INTO commits_records (owner, active, state, score, rank) VALUES ('blue', 79, 'edge', 42.65, 48);
INSERT INTO commits_records (owner, active, state, score, rank) VALUES ('cached', 65, 'legacy', 8.78, 41);
