-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (token, state, count, score) VALUES ('stable', 'latest', 89, 65.52);
INSERT INTO commits_records (token, state, count, score) VALUES ('eu-west', 'stable', 5, 1.22);
INSERT INTO commits_records (token, state, count, score) VALUES ('primary', 'primary', 91, 9.26);
