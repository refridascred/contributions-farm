-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (owner, weight, token, state, active) VALUES ('staging', 11.47, 'eu-west', 'open', 79);
INSERT INTO commits_records (owner, weight, token, state, active) VALUES ('staging', 11.1, 'open', 'legacy', 22);
INSERT INTO commits_records (owner, weight, token, state, active) VALUES ('cached', 75.88, 'primary', 'blue', 94);
