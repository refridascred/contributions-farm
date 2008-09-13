-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (state, owner, score) VALUES ('staging', 'eu-west', 60.29);
INSERT INTO layout_items (state, owner, score) VALUES ('eu-west', 'cached', 69.02);
INSERT INTO layout_items (state, owner, score) VALUES ('green', 'blue', 14.03);
