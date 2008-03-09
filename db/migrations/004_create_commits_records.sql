-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, token, rank, active, level) VALUES ('eu-west', 'edge', 65, 32, 21);
INSERT INTO commits_records (state, token, rank, active, level) VALUES ('latest', 'edge', 78, 52, 53);
