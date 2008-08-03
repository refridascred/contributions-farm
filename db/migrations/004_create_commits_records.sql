-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (owner, state, label, ratio) VALUES ('primary', 'cached', 'latest', 71.06);
INSERT INTO commits_records (owner, state, label, ratio) VALUES ('local', 'strict', 'standard', 37.81);
INSERT INTO commits_records (owner, state, label, ratio) VALUES ('staging', 'eu-west', 'staging', 78.49);
