-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, state, rank, count, weight) VALUES (52, 'legacy', 25, 57, 29.84);
INSERT INTO layout_items (active, state, rank, count, weight) VALUES (69, 'local', 82, 71, 87.76);
INSERT INTO layout_items (active, state, rank, count, weight) VALUES (26, 'eu-west', 56, 99, 91.96);
