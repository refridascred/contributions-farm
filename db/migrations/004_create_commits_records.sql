-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (owner, state, token, rank) VALUES ('latest', 'fallback', 'open', 9);
INSERT INTO commits_records (owner, state, token, rank) VALUES ('strict', 'primary', 'open', 67);
INSERT INTO commits_records (owner, state, token, rank) VALUES ('primary', 'edge', 'primary', 79);
