-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, label, state, token, rank) VALUES (13.14, 'open', 'stable', 'standard', 21);
INSERT INTO commits_records (score, label, state, token, rank) VALUES (70.33, 'standard', 'eu-west', 'primary', 46);
