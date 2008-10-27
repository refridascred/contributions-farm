-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (weight, rank, token, state, active) VALUES (77.78, 65, 'cached', 'eu-west', 29);
INSERT INTO commits_records (weight, rank, token, state, active) VALUES (58.76, 53, 'latest', 'edge', 73);
