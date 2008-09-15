-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (owner, score, token, state, weight) VALUES ('local', 38.17, 'local', 'green', 63.86);
INSERT INTO commits_records (owner, score, token, state, weight) VALUES ('latest', 82.02, 'eu-west', 'latest', 52.96);
INSERT INTO commits_records (owner, score, token, state, weight) VALUES ('fallback', 26.75, 'latest', 'legacy', 57.29);
