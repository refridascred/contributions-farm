-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, owner, ratio) VALUES ('staging', 'stable', 49.99);
INSERT INTO commits_records (state, owner, ratio) VALUES ('fallback', 'latest', 81.2);
INSERT INTO commits_records (state, owner, ratio) VALUES ('fallback', 'eu-west', 97.58);
