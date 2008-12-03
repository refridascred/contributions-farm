-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (score, state, owner, weight) VALUES (82.09, 'eu-west', 'legacy', 70.4);
INSERT INTO commits_records (score, state, owner, weight) VALUES (21.86, 'local', 'primary', 78.33);
