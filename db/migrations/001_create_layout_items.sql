-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, state, rank, score, token) VALUES ('cached', 'staging', 9, 52.01, 'eu-west');
INSERT INTO layout_items (owner, state, rank, score, token) VALUES ('staging', 'eu-west', 95, 9.94, 'green');
