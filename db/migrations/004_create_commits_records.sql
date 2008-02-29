-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (owner, active, state, label, count) VALUES ('green', 28, 'eu-west', 'standard', 99);
INSERT INTO commits_records (owner, active, state, label, count) VALUES ('blue', 67, 'open', 'cached', 38);
INSERT INTO commits_records (owner, active, state, label, count) VALUES ('local', 95, 'standard', 'blue', 61);
