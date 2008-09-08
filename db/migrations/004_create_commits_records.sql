-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (state, count, label, token, owner) VALUES ('latest', 75, 'latest', 'latest', 'local');
INSERT INTO commits_records (state, count, label, token, owner) VALUES ('cached', 83, 'local', 'legacy', 'blue');
INSERT INTO commits_records (state, count, label, token, owner) VALUES ('stable', 3, 'local', 'eu-west', 'local');
