-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (active, state, ratio, label) VALUES (94, 'latest', 72.43, 'primary');
INSERT INTO commits_records (active, state, ratio, label) VALUES (62, 'strict', 67.1, 'eu-west');
INSERT INTO commits_records (active, state, ratio, label) VALUES (28, 'latest', 11.34, 'standard');
