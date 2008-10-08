-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (state, owner, score, level) VALUES ('strict', 'stable', 95.71, 13);
INSERT INTO commits_records (state, owner, score, level) VALUES ('eu-west', 'local', 94.17, 63);
INSERT INTO commits_records (state, owner, score, level) VALUES ('fallback', 'staging', 7.56, 7);
