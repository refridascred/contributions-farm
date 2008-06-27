-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (owner, state, weight) VALUES ('latest', 'eu-west', 55.39);
INSERT INTO commits_records (owner, state, weight) VALUES ('primary', 'stable', 16.36);
INSERT INTO commits_records (owner, state, weight) VALUES ('blue', 'standard', 11.7);
