-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (level, owner, state, token, weight) VALUES (14, 'blue', 'primary', 'edge', 36.82);
INSERT INTO commits_records (level, owner, state, token, weight) VALUES (41, 'strict', 'standard', 'blue', 86.5);
INSERT INTO commits_records (level, owner, state, token, weight) VALUES (96, 'stable', 'legacy', 'local', 32.86);
