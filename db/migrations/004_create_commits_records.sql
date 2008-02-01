-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (state, owner, rank) VALUES ('cached', 'strict', 62);
INSERT INTO commits_records (state, owner, rank) VALUES ('open', 'fallback', 25);
INSERT INTO commits_records (state, owner, rank) VALUES ('open', 'edge', 71);
