-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (state, count, token, label) VALUES ('fallback', 34, 'stable', 'fallback');
INSERT INTO commits_records (state, count, token, label) VALUES ('legacy', 82, 'blue', 'latest');
INSERT INTO commits_records (state, count, token, label) VALUES ('edge', 72, 'standard', 'latest');
