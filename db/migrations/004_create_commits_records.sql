-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (level, rank, token, state) VALUES (25, 22, 'local', 'edge');
INSERT INTO commits_records (level, rank, token, state) VALUES (15, 54, 'primary', 'eu-west');
INSERT INTO commits_records (level, rank, token, state) VALUES (62, 24, 'latest', 'staging');
