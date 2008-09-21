-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, active, score) VALUES ('cached', 86, 69.04);
INSERT INTO commits_records (state, active, score) VALUES ('local', 48, 81.71);
INSERT INTO commits_records (state, active, score) VALUES ('eu-west', 41, 79.04);
