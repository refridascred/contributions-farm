-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (state, ratio, owner, label) VALUES ('strict', 75.16, 'staging', 'green');
INSERT INTO commits_records (state, ratio, owner, label) VALUES ('open', 83.28, 'strict', 'local');
INSERT INTO commits_records (state, ratio, owner, label) VALUES ('fallback', 82.68, 'local', 'green');
