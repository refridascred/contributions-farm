-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (state, active, owner, token, weight) VALUES ('staging', 61, 'blue', 'primary', 11.09);
INSERT INTO commits_records (state, active, owner, token, weight) VALUES ('local', 90, 'latest', 'staging', 64.57);
INSERT INTO commits_records (state, active, owner, token, weight) VALUES ('local', 43, 'strict', 'edge', 59.31);
