-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (weight, state, owner) VALUES (29.95, 'open', 'latest');
INSERT INTO commits_records (weight, state, owner) VALUES (30.97, 'staging', 'staging');
INSERT INTO commits_records (weight, state, owner) VALUES (85.87, 'latest', 'eu-west');
