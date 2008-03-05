-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (owner, state, weight) VALUES ('eu-west', 'edge', 92.22);
INSERT INTO commits_records (owner, state, weight) VALUES ('staging', 'blue', 85.92);
INSERT INTO commits_records (owner, state, weight) VALUES ('edge', 'latest', 95.73);
