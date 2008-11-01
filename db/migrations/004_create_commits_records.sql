-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (state, owner, label, rank) VALUES ('green', 'local', 'cached', 21);
INSERT INTO commits_records (state, owner, label, rank) VALUES ('strict', 'open', 'blue', 35);
