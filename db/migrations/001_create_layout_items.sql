-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, state, rank) VALUES (86, 'strict', 97);
INSERT INTO layout_items (count, state, rank) VALUES (65, 'legacy', 70);
INSERT INTO layout_items (count, state, rank) VALUES (15, 'standard', 71);
