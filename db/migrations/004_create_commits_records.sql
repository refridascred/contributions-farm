-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (state, owner, count, active, score) VALUES ('eu-west', 'primary', 65, 24, 23.08);
INSERT INTO commits_records (state, owner, count, active, score) VALUES ('primary', 'cached', 46, 92, 71.49);
INSERT INTO commits_records (state, owner, count, active, score) VALUES ('blue', 'local', 40, 51, 5.07);
