-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (level, rank, state) VALUES (20, 80, 'eu-west');
INSERT INTO commits_records (level, rank, state) VALUES (91, 98, 'strict');
INSERT INTO commits_records (level, rank, state) VALUES (71, 49, 'local');
