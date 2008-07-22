-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    ratio REAL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (count, rank, ratio, token, state) VALUES (1, 92, 32.07, 'primary', 'edge');
INSERT INTO commits_records (count, rank, ratio, token, state) VALUES (15, 94, 95.58, 'eu-west', 'strict');
INSERT INTO commits_records (count, rank, ratio, token, state) VALUES (40, 0, 65.44, 'local', 'blue');
