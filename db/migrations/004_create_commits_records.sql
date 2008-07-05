-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (state, owner, active, ratio) VALUES ('cached', 'fallback', 53, 1.17);
INSERT INTO commits_records (state, owner, active, ratio) VALUES ('fallback', 'staging', 74, 63.85);
INSERT INTO commits_records (state, owner, active, ratio) VALUES ('open', 'latest', 97, 65.88);
