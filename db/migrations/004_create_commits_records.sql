-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (state, owner, ratio, weight) VALUES ('blue', 'open', 6.23, 50.65);
INSERT INTO commits_records (state, owner, ratio, weight) VALUES ('open', 'eu-west', 62.46, 89.08);
