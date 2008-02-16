-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (token, label, score, state, weight) VALUES ('open', 'latest', 30.83, 'blue', 58.79);
INSERT INTO commits_records (token, label, score, state, weight) VALUES ('latest', 'cached', 66.09, 'staging', 14.63);
