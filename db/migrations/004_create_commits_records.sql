-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (score, state, token, rank, ratio) VALUES (31.81, 'blue', 'open', 30, 35.74);
INSERT INTO commits_records (score, state, token, rank, ratio) VALUES (21.7, 'primary', 'standard', 25, 17.29);
INSERT INTO commits_records (score, state, token, rank, ratio) VALUES (66.0, 'staging', 'edge', 30, 56.21);
