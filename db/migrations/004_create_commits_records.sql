-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (state, owner, rank, score) VALUES ('blue', 'eu-west', 91, 67.83);
INSERT INTO commits_records (state, owner, rank, score) VALUES ('eu-west', 'blue', 66, 70.57);
INSERT INTO commits_records (state, owner, rank, score) VALUES ('staging', 'blue', 2, 19.31);
