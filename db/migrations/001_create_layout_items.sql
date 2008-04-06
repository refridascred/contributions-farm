-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, state, weight, owner, rank) VALUES (13, 'standard', 51.63, 'strict', 58);
INSERT INTO layout_items (active, state, weight, owner, rank) VALUES (1, 'legacy', 96.25, 'green', 85);
