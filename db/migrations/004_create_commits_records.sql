-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (owner, active, state) VALUES ('cached', 86, 'staging');
INSERT INTO commits_records (owner, active, state) VALUES ('stable', 98, 'green');
INSERT INTO commits_records (owner, active, state) VALUES ('eu-west', 44, 'green');
