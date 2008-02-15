-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, score, token, state) VALUES ('standard', 17.22, 'legacy', 'green');
INSERT INTO layout_items (owner, score, token, state) VALUES ('edge', 91.55, 'local', 'legacy');
