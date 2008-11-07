-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, state, score, token, count) VALUES ('latest', 'eu-west', 90.44, 'eu-west', 64);
INSERT INTO layout_items (owner, state, score, token, count) VALUES ('blue', 'legacy', 78.43, 'green', 31);
INSERT INTO layout_items (owner, state, score, token, count) VALUES ('primary', 'local', 12.31, 'cached', 76);
