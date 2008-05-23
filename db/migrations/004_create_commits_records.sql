-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, token, owner, score) VALUES ('strict', 'eu-west', 'primary', 25.27);
INSERT INTO commits_records (state, token, owner, score) VALUES ('cached', 'blue', 'latest', 1.5);
INSERT INTO commits_records (state, token, owner, score) VALUES ('eu-west', 'green', 'eu-west', 86.22);
