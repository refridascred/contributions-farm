-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (token, owner, state, rank) VALUES ('latest', 'fallback', 'strict', 58);
INSERT INTO layout_items (token, owner, state, rank) VALUES ('standard', 'strict', 'eu-west', 9);
