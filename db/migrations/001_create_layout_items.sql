-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (state, owner, weight) VALUES ('eu-west', 'latest', 25.35);
INSERT INTO layout_items (state, owner, weight) VALUES ('stable', 'edge', 93.67);
