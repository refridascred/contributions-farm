-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (count, token, state, ratio) VALUES (85, 'blue', 'stable', 66.81);
INSERT INTO commits_records (count, token, state, ratio) VALUES (42, 'staging', 'legacy', 64.13);
INSERT INTO commits_records (count, token, state, ratio) VALUES (30, 'eu-west', 'strict', 86.27);
