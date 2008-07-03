-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, token, score) VALUES ('staging', 'blue', 93.16);
INSERT INTO commits_records (state, token, score) VALUES ('stable', 'eu-west', 72.31);
INSERT INTO commits_records (state, token, score) VALUES ('strict', 'open', 77.77);
