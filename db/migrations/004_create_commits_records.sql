-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (rank, owner, state, token, score) VALUES (27, 'strict', 'staging', 'standard', 93.51);
INSERT INTO commits_records (rank, owner, state, token, score) VALUES (28, 'blue', 'primary', 'green', 38.55);
INSERT INTO commits_records (rank, owner, state, token, score) VALUES (3, 'eu-west', 'green', 'fallback', 9.72);
