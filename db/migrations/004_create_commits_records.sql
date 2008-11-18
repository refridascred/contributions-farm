-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (count, token, state, ratio) VALUES (53, 'eu-west', 'green', 7.18);
INSERT INTO commits_records (count, token, state, ratio) VALUES (84, 'strict', 'eu-west', 71.03);
INSERT INTO commits_records (count, token, state, ratio) VALUES (14, 'staging', 'fallback', 80.79);
