-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (state, owner, rank, weight) VALUES ('legacy', 'stable', 14, 0.6);
INSERT INTO layout_items (state, owner, rank, weight) VALUES ('green', 'blue', 18, 32.35);
