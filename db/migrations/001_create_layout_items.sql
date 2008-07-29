-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (weight, rank, count, state) VALUES (28.13, 98, 93, 'strict');
INSERT INTO layout_items (weight, rank, count, state) VALUES (23.39, 54, 87, 'legacy');
INSERT INTO layout_items (weight, rank, count, state) VALUES (6.86, 0, 28, 'fallback');
