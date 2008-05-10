-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (ratio, label, owner, state) VALUES (28.56, 'stable', 'latest', 'open');
INSERT INTO commits_records (ratio, label, owner, state) VALUES (34.86, 'legacy', 'green', 'cached');
