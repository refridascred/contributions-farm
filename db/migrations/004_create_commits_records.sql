-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (level, state, token, rank) VALUES (97, 'green', 'cached', 68);
INSERT INTO commits_records (level, state, token, rank) VALUES (25, 'eu-west', 'latest', 96);
