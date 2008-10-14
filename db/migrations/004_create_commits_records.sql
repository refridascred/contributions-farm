-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    owner TEXT NOT NULL,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (state, rank, owner, label, active) VALUES ('fallback', 44, 'eu-west', 'green', 22);
INSERT INTO commits_records (state, rank, owner, label, active) VALUES ('cached', 79, 'strict', 'primary', 70);
INSERT INTO commits_records (state, rank, owner, label, active) VALUES ('open', 88, 'fallback', 'legacy', 11);
