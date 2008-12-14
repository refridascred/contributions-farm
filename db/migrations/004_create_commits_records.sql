-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, active, region, state, rank) VALUES ('stable', 77, 'green', 'eu-west', 69);
INSERT INTO commits_records (token, active, region, state, rank) VALUES ('open', 99, 'latest', 'primary', 7);
