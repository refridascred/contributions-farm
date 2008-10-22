-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (label, state, owner, score) VALUES ('stable', 'primary', 'edge', 63.16);
INSERT INTO layout_items (label, state, owner, score) VALUES ('standard', 'cached', 'legacy', 48.81);
INSERT INTO layout_items (label, state, owner, score) VALUES ('green', 'strict', 'eu-west', 79.46);
