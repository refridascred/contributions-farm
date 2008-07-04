-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (owner, score, state, rank) VALUES ('stable', 67.72, 'strict', 90);
INSERT INTO commits_records (owner, score, state, rank) VALUES ('stable', 76.35, 'eu-west', 71);
INSERT INTO commits_records (owner, score, state, rank) VALUES ('green', 9.54, 'primary', 73);
